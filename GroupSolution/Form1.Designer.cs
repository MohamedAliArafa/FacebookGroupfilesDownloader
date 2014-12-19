namespace GroupSolution
{
    partial class btnMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnMaster));
            this.imgAccount = new System.Windows.Forms.PictureBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lstName = new System.Windows.Forms.ListBox();
            this.btnMast = new System.Windows.Forms.Button();
            this.btnImages = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressGroup = new System.Windows.Forms.ProgressBar();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAccount
            // 
            this.imgAccount.Location = new System.Drawing.Point(24, 25);
            this.imgAccount.Name = "imgAccount";
            this.imgAccount.Size = new System.Drawing.Size(47, 44);
            this.imgAccount.TabIndex = 0;
            this.imgAccount.TabStop = false;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(21, 9);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(66, 13);
            this.lblAccountName.TabIndex = 1;
            this.lblAccountName.Text = "Please Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 75);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(103, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Select Group";
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.Location = new System.Drawing.Point(106, 25);
            this.lstName.Name = "lstName";
            this.lstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstName.Size = new System.Drawing.Size(669, 342);
            this.lstName.TabIndex = 6;
            // 
            // btnMast
            // 
            this.btnMast.Location = new System.Drawing.Point(781, 168);
            this.btnMast.Name = "btnMast";
            this.btnMast.Size = new System.Drawing.Size(75, 23);
            this.btnMast.TabIndex = 9;
            this.btnMast.Text = "Get Groups";
            this.btnMast.UseVisualStyleBackColor = true;
            this.btnMast.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImages
            // 
            this.btnImages.Location = new System.Drawing.Point(781, 197);
            this.btnImages.Name = "btnImages";
            this.btnImages.Size = new System.Drawing.Size(75, 23);
            this.btnImages.TabIndex = 10;
            this.btnImages.Text = "Get Images";
            this.btnImages.UseVisualStyleBackColor = true;
            this.btnImages.Click += new System.EventHandler(this.btnImages_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressGroup
            // 
            this.progressGroup.Location = new System.Drawing.Point(782, 152);
            this.progressGroup.Name = "progressGroup";
            this.progressGroup.Size = new System.Drawing.Size(75, 10);
            this.progressGroup.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(782, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update Text";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 400);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.progressGroup);
            this.Controls.Add(this.btnImages);
            this.Controls.Add(this.btnMast);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.imgAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnMaster";
            this.Text = "GroupSolution";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAccount;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.Button btnMast;
        private System.Windows.Forms.Button btnImages;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressGroup;
        private System.Windows.Forms.Button btnUpdate;
    }
}

