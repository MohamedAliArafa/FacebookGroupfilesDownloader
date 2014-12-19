namespace GroupSolution
{
    partial class Logout
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
            this.webLogout = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webLogout
            // 
            this.webLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webLogout.Location = new System.Drawing.Point(0, 0);
            this.webLogout.MinimumSize = new System.Drawing.Size(20, 20);
            this.webLogout.Name = "webLogout";
            this.webLogout.Size = new System.Drawing.Size(284, 261);
            this.webLogout.TabIndex = 0;
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.webLogout);
            this.Name = "Logout";
            this.Text = "Logout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Logout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webLogout;
    }
}