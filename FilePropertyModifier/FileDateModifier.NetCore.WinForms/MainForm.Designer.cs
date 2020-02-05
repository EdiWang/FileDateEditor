namespace FileDateEditor.WinForms
{
    partial class MainForm
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
            this.DtpCreateTime = new System.Windows.Forms.DateTimePicker();
            this.BtnApply = new System.Windows.Forms.Button();
            this.OpenFileDig = new System.Windows.Forms.OpenFileDialog();
            this.TxtFilePath = new System.Windows.Forms.TextBox();
            this.BtnChooseFile = new System.Windows.Forms.Button();
            this.LblMessage = new System.Windows.Forms.Label();
            this.GrpFilePicker = new System.Windows.Forms.GroupBox();
            this.GrpTimePicker = new System.Windows.Forms.GroupBox();
            this.DtpAccessTime = new System.Windows.Forms.DateTimePicker();
            this.LblAccessTime = new System.Windows.Forms.Label();
            this.DtpModifyTime = new System.Windows.Forms.DateTimePicker();
            this.LblModifiedTime = new System.Windows.Forms.Label();
            this.LblCreationTime = new System.Windows.Forms.Label();
            this.GrpFilePicker.SuspendLayout();
            this.GrpTimePicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtpCreateTime
            // 
            this.DtpCreateTime.Location = new System.Drawing.Point(82, 22);
            this.DtpCreateTime.Name = "DtpCreateTime";
            this.DtpCreateTime.Size = new System.Drawing.Size(200, 20);
            this.DtpCreateTime.TabIndex = 0;
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(302, 212);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 25);
            this.BtnApply.TabIndex = 1;
            this.BtnApply.Text = "应用操作";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // OpenFileDig
            // 
            this.OpenFileDig.FileName = "OpenFileDig";
            // 
            // TxtFilePath
            // 
            this.TxtFilePath.Location = new System.Drawing.Point(6, 22);
            this.TxtFilePath.Name = "TxtFilePath";
            this.TxtFilePath.Size = new System.Drawing.Size(276, 20);
            this.TxtFilePath.TabIndex = 2;
            // 
            // BtnChooseFile
            // 
            this.BtnChooseFile.Location = new System.Drawing.Point(288, 20);
            this.BtnChooseFile.Name = "BtnChooseFile";
            this.BtnChooseFile.Size = new System.Drawing.Size(75, 25);
            this.BtnChooseFile.TabIndex = 3;
            this.BtnChooseFile.Text = "选择文件";
            this.BtnChooseFile.UseVisualStyleBackColor = true;
            this.BtnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Location = new System.Drawing.Point(21, 218);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(231, 13);
            this.LblMessage.TabIndex = 4;
            this.LblMessage.Text = "居家旅行，杀人灭口，考试作弊，必备神器。";
            // 
            // GrpFilePicker
            // 
            this.GrpFilePicker.Controls.Add(this.TxtFilePath);
            this.GrpFilePicker.Controls.Add(this.BtnChooseFile);
            this.GrpFilePicker.Location = new System.Drawing.Point(14, 13);
            this.GrpFilePicker.Name = "GrpFilePicker";
            this.GrpFilePicker.Size = new System.Drawing.Size(377, 59);
            this.GrpFilePicker.TabIndex = 5;
            this.GrpFilePicker.TabStop = false;
            this.GrpFilePicker.Text = "第一步：选择要修改的文件";
            // 
            // GrpTimePicker
            // 
            this.GrpTimePicker.Controls.Add(this.DtpAccessTime);
            this.GrpTimePicker.Controls.Add(this.LblAccessTime);
            this.GrpTimePicker.Controls.Add(this.DtpModifyTime);
            this.GrpTimePicker.Controls.Add(this.LblModifiedTime);
            this.GrpTimePicker.Controls.Add(this.LblCreationTime);
            this.GrpTimePicker.Controls.Add(this.DtpCreateTime);
            this.GrpTimePicker.Location = new System.Drawing.Point(14, 79);
            this.GrpTimePicker.Name = "GrpTimePicker";
            this.GrpTimePicker.Size = new System.Drawing.Size(377, 124);
            this.GrpTimePicker.TabIndex = 6;
            this.GrpTimePicker.TabStop = false;
            this.GrpTimePicker.Text = "第二步：选择日期";
            // 
            // DtpAccessTime
            // 
            this.DtpAccessTime.Location = new System.Drawing.Point(82, 82);
            this.DtpAccessTime.Name = "DtpAccessTime";
            this.DtpAccessTime.Size = new System.Drawing.Size(200, 20);
            this.DtpAccessTime.TabIndex = 5;
            // 
            // LblAccessTime
            // 
            this.LblAccessTime.AutoSize = true;
            this.LblAccessTime.Location = new System.Drawing.Point(7, 89);
            this.LblAccessTime.Name = "LblAccessTime";
            this.LblAccessTime.Size = new System.Drawing.Size(61, 13);
            this.LblAccessTime.TabIndex = 4;
            this.LblAccessTime.Text = "访问时间：";
            // 
            // DtpModifyTime
            // 
            this.DtpModifyTime.Location = new System.Drawing.Point(82, 53);
            this.DtpModifyTime.Name = "DtpModifyTime";
            this.DtpModifyTime.Size = new System.Drawing.Size(200, 20);
            this.DtpModifyTime.TabIndex = 3;
            // 
            // LblModifiedTime
            // 
            this.LblModifiedTime.AutoSize = true;
            this.LblModifiedTime.Location = new System.Drawing.Point(7, 60);
            this.LblModifiedTime.Name = "LblModifiedTime";
            this.LblModifiedTime.Size = new System.Drawing.Size(61, 13);
            this.LblModifiedTime.TabIndex = 2;
            this.LblModifiedTime.Text = "修改时间：";
            // 
            // LblCreationTime
            // 
            this.LblCreationTime.AutoSize = true;
            this.LblCreationTime.Location = new System.Drawing.Point(7, 30);
            this.LblCreationTime.Name = "LblCreationTime";
            this.LblCreationTime.Size = new System.Drawing.Size(61, 13);
            this.LblCreationTime.TabIndex = 1;
            this.LblCreationTime.Text = "创建时间：";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 252);
            this.Controls.Add(this.GrpTimePicker);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.GrpFilePicker);
            this.Controls.Add(this.LblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "文件日期修改器 by Edi.Wang ";
            this.GrpFilePicker.ResumeLayout(false);
            this.GrpFilePicker.PerformLayout();
            this.GrpTimePicker.ResumeLayout(false);
            this.GrpTimePicker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpCreateTime;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.OpenFileDialog OpenFileDig;
        private System.Windows.Forms.TextBox TxtFilePath;
        private System.Windows.Forms.Button BtnChooseFile;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.GroupBox GrpFilePicker;
        private System.Windows.Forms.GroupBox GrpTimePicker;
        private System.Windows.Forms.DateTimePicker DtpAccessTime;
        private System.Windows.Forms.Label LblAccessTime;
        private System.Windows.Forms.DateTimePicker DtpModifyTime;
        private System.Windows.Forms.Label LblModifiedTime;
        private System.Windows.Forms.Label LblCreationTime;
    }
}

