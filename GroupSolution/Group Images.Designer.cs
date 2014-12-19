namespace GroupSolution
{
    partial class Group_Images
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbDownload = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 199);
            this.listBox1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(330, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Click Download To Begin \"D:\\Groupsolutions\\{group_name}\\images\"";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(319, 234);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(167, 27);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 234);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(202, 10);
            this.progressBar1.TabIndex = 3;
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(349, 29);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(220, 199);
            this.pbDownload.TabIndex = 4;
            this.pbDownload.TabStop = false;
            // 
            // Group_Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 271);
            this.Controls.Add(this.pbDownload);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.listBox1);
            this.Name = "Group_Images";
            this.Text = "Group_Images";
            this.Load += new System.EventHandler(this.Group_Images_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDownload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pbDownload;
    }
}