namespace GroupSolution
{
    partial class Group_Files
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
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.lblDownload = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.progressGroup = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lstDownload = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 38);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(293, 186);
            this.lstFiles.TabIndex = 0;
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(12, 19);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(293, 13);
            this.lblDownload.TabIndex = 1;
            this.lblDownload.Text = "Click Download To Begin \"D:\\Groupsolutions\\{group_name}\"";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(312, 230);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(126, 23);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // progressGroup
            // 
            this.progressGroup.Location = new System.Drawing.Point(13, 230);
            this.progressGroup.Name = "progressGroup";
            this.progressGroup.Size = new System.Drawing.Size(204, 11);
            this.progressGroup.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstDownload
            // 
            this.lstDownload.FormattingEnabled = true;
            this.lstDownload.Location = new System.Drawing.Point(312, 64);
            this.lstDownload.Name = "lstDownload";
            this.lstDownload.Size = new System.Drawing.Size(464, 160);
            this.lstDownload.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Files Already Exist";
            // 
            // Group_Files
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDownload);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressGroup);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.lstFiles);
            this.Name = "Group_Files";
            this.Text = "Group_Files";
            this.Load += new System.EventHandler(this.Group_Files_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar progressGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstDownload;
        private System.Windows.Forms.Label label1;
    }
}