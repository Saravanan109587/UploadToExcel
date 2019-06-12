using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadExcel
{
    public partial class btn_upload : Form
    {

        #region  Model
        public class ResponseBase
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
        }
        public class FundDetails
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime StartDate { get; set; } = new DateTime(1990, 1, 1);
            public DateTime EndDate { get; set; } = new DateTime(1990, 1, 1);
            public int Frequency { get; set; }
        }
        public class CalcStatResponse
        {
            public DateTime Date { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Value { get; set; }
        }

        public class StatValue
        {
            public DateTime Name { get; set; }
            public double Value { get; set; }
        }
        public class CalculationResponse : ResponseBase
        {
            public FundDetails Fund { get; set; }
            public List<CalcStatResponse> Stats { get; set; }
        }

        #endregion

        public btn_upload()
        {
            InitializeComponent();
        }
        string fileNames = @"D:\Code\CalculationStats.xlsx";
        private void select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();
            openfiledialog1.ShowDialog();
            openfiledialog1.Filter = "allfiles|*.xls";
            Path.Text = openfiledialog1.FileName;
        }
        public void WriteinDbFromEXel(string path)
        {
            DataTable dtResult = null;
            int totalSheet = 0; //No of sheets on excel file  
            using (OleDbConnection objConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';"))
            {
                objConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                DataSet ds = new DataSet();
                DataTable dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = string.Empty;
                if (dt != null)
                {
                    var tempDataTable = (from dataRow in dt.AsEnumerable()
                                         where !dataRow["TABLE_NAME"].ToString().Contains("FilterDatabase")
                                         select dataRow).CopyToDataTable();
                    dt = tempDataTable;
                    totalSheet = dt.Rows.Count;
                    sheetName = dt.Rows[0]["TABLE_NAME"].ToString();
                }
                cmd.Connection = objConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                oleda = new OleDbDataAdapter(cmd);
                oleda.Fill(ds, "excelData");
                dtResult = ds.Tables["excelData"];
                objConn.Close();

                using (var bulkCopy = new SqlBulkCopy("data source=PTDEVDB01;initial catalog=AlternativeSoft_DB;persist security info=True;user id=asoft;Password=alter@123", SqlBulkCopyOptions.KeepIdentity))
                {
                    // my DataTable column names match my SQL Column names, so I simply made this loop. However if your column names don't match, just pass in which datatable name matches the SQL column name in Column Mappings
                    foreach (DataColumn col in dtResult.Columns)
                    {
                        bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                    }

                    bulkCopy.BulkCopyTimeout = 600;
                    bulkCopy.DestinationTableName = "API_StatResponse";
                    bulkCopy.WriteToServer(dtResult);
                }
            }
        }
        private void Upload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Path.Text))
                WriteinDbFromEXel(Path.Text);
            else
                MessageBox.Show("Please Select File to Upload");
        }

        public void GenerateExcel(List<CalculationResponse> Dtaa,string path)
        { 
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                //Set some properties of the Excel document
                excelPackage.Workbook.Properties.Author = "VDWWD";
                excelPackage.Workbook.Properties.Title = "STAT RESPONSE";
                excelPackage.Workbook.Properties.Subject = "STAT RESPONSE";
                excelPackage.Workbook.Properties.Created = DateTime.Now;

                //Create the WorkSheet
                ExcelWorksheet myWorksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");

                myWorksheet.Cells["B2"].Value = "FUND_NAME";
                myWorksheet.Cells["C2"].Value = "STAT_NAME";
                myWorksheet.Cells["D2"].Value = "STAT_VALUE";
                myWorksheet.Cells["E2"].Value = "STATE_DATE";
                var i = 0;
                foreach (var item in Dtaa)
                {
                    foreach (var sta in item.Stats)
                    {
                        myWorksheet.Cells["B" + (i + 3)].Value = item.Fund.Name;
                        myWorksheet.Cells["C" + (i + 3)].Value = sta.Name;
                        myWorksheet.Cells["D" + (i + 3)].Value = sta.Value;
                        myWorksheet.Cells["E" + (i + 3)].Value = sta.Date.ToString();
                        i++;
                    }

                }
                

                if (File.Exists(fileNames))
                {
                    // If file found, delete it    
                    File.Delete(fileNames);
                   
                }
                // Add to 6th row and to the 6th column 
                
                //Save your file
                FileInfo fi = new FileInfo(fileNames);
                excelPackage.SaveAs(fi);
                if (check_Db.Checked)
                {
                    WriteinDbFromEXel(path);
                }
                //System.Diagnostics.Process.Start(fileNames);
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(request.Text) || string.IsNullOrEmpty(txt_requestUrl.Text))
            {
                MessageBox.Show("Enter Request Data");
            }
            else
            {
            callAPIANdSaveintoDB();
            }
        }

        public async Task<List<CalculationResponse>> callAPi()
        {
            var response = "";
            JsonSerializerSettings dateFormat = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
            };
            using (HttpClient client = new HttpClient())
            {
               
                //will return the Http content if the request has value else will return null
                using (var httpContent = request != null ? new StringContent(request.Text, Encoding.UTF8, "application/json") : null)

                using (var webResponse = await client.PostAsync(txt_requestUrl.Text.Trim(), httpContent))
                {
                    var content = await webResponse.Content.ReadAsStringAsync();
                    response = content;
                }
            }

            var data = JsonConvert.DeserializeObject<List<CalculationResponse>>(response);


            return data;

        }

        public async void callAPIANdSaveintoDB()
        {
            List<CalculationResponse> list = await callAPi();
            GenerateExcel(list,fileNames);
             
        }
    }
}
