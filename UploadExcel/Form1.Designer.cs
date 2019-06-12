namespace UploadExcel
{
    partial class btn_upload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.select = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.Upload = new System.Windows.Forms.Button();
            this.request = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_requestUrl = new System.Windows.Forms.TextBox();
            this.lbl_reuest = new System.Windows.Forms.Label();
            this.api_check_Db = new System.Windows.Forms.CheckBox();
            this.txt_TableName = new System.Windows.Forms.TextBox();
            this.lbl_tableName = new System.Windows.Forms.Label();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(391, 40);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(179, 35);
            this.select.TabIndex = 0;
            this.select.Text = "Select File";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(78, 48);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(266, 20);
            this.Path.TabIndex = 1;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(196, 110);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(231, 23);
            this.Upload.TabIndex = 2;
            this.Upload.Text = "Upload from Location";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // request
            // 
            this.request.Location = new System.Drawing.Point(284, 183);
            this.request.Multiline = true;
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(276, 155);
            this.request.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Call API & Write Into EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_requestUrl
            // 
            this.txt_requestUrl.Location = new System.Drawing.Point(12, 242);
            this.txt_requestUrl.Name = "txt_requestUrl";
            this.txt_requestUrl.Size = new System.Drawing.Size(266, 20);
            this.txt_requestUrl.TabIndex = 5;
            this.txt_requestUrl.Text = "https://localhost:5001/api/Statistics/Stats";
            // 
            // lbl_reuest
            // 
            this.lbl_reuest.AutoSize = true;
            this.lbl_reuest.Location = new System.Drawing.Point(12, 226);
            this.lbl_reuest.Name = "lbl_reuest";
            this.lbl_reuest.Size = new System.Drawing.Size(72, 13);
            this.lbl_reuest.TabIndex = 6;
            this.lbl_reuest.Text = "Request URL";
            // 
            // api_check_Db
            // 
            this.api_check_Db.AutoSize = true;
            this.api_check_Db.Location = new System.Drawing.Point(630, 116);
            this.api_check_Db.Name = "api_check_Db";
            this.api_check_Db.Size = new System.Drawing.Size(82, 17);
            this.api_check_Db.TabIndex = 7;
            this.api_check_Db.Text = "Insert to DB";
            this.api_check_Db.UseVisualStyleBackColor = true;
            this.api_check_Db.CheckedChanged += new System.EventHandler(this.api_check_Db_CheckedChanged);
            // 
            // txt_TableName
            // 
            this.txt_TableName.Location = new System.Drawing.Point(630, 183);
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.Size = new System.Drawing.Size(129, 20);
            this.txt_TableName.TabIndex = 8;
            this.txt_TableName.Text = "API_StatResponse";
            this.txt_TableName.Visible = false;
            // 
            // lbl_tableName
            // 
            this.lbl_tableName.AutoSize = true;
            this.lbl_tableName.Location = new System.Drawing.Point(627, 167);
            this.lbl_tableName.Name = "lbl_tableName";
            this.lbl_tableName.Size = new System.Drawing.Size(65, 13);
            this.lbl_tableName.TabIndex = 9;
            this.lbl_tableName.Text = "Table Name";
            this.lbl_tableName.Visible = false;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(12, 302);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(182, 13);
            this.lbl_FileName.TabIndex = 12;
            this.lbl_FileName.Text = "File Name Which is stored in desktop";
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(12, 318);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(266, 20);
            this.txt_FileName.TabIndex = 11;
            this.txt_FileName.Text = "StatResponse.xlsx";
            // 
            // btn_upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.lbl_tableName);
            this.Controls.Add(this.txt_TableName);
            this.Controls.Add(this.api_check_Db);
            this.Controls.Add(this.lbl_reuest);
            this.Controls.Add(this.txt_requestUrl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.request);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.select);
            this.Name = "btn_upload";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.TextBox request;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_requestUrl;
        private System.Windows.Forms.Label lbl_reuest;
        private System.Windows.Forms.CheckBox api_check_Db;
        private System.Windows.Forms.TextBox txt_TableName;
        private System.Windows.Forms.Label lbl_tableName;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.TextBox txt_FileName;
    }
}

