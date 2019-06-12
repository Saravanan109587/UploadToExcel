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
            this.check_Db = new System.Windows.Forms.CheckBox();
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
            this.Upload.Text = "button1";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // request
            // 
            this.request.Location = new System.Drawing.Point(304, 182);
            this.request.Multiline = true;
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(398, 155);
            this.request.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Call APi";
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
            this.lbl_reuest.Location = new System.Drawing.Point(26, 226);
            this.lbl_reuest.Name = "lbl_reuest";
            this.lbl_reuest.Size = new System.Drawing.Size(72, 13);
            this.lbl_reuest.TabIndex = 6;
            this.lbl_reuest.Text = "Request URL";
            // 
            // check_Db
            // 
            this.check_Db.AutoSize = true;
            this.check_Db.Location = new System.Drawing.Point(708, 213);
            this.check_Db.Name = "check_Db";
            this.check_Db.Size = new System.Drawing.Size(80, 17);
            this.check_Db.TabIndex = 7;
            this.check_Db.Text = "checkBox1";
            this.check_Db.UseVisualStyleBackColor = true;
            // 
            // btn_upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check_Db);
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
        private System.Windows.Forms.CheckBox check_Db;
    }
}

