namespace Saper
{
    partial class Form2
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
            this.Saper = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Saper
            // 
            this.Saper.Location = new System.Drawing.Point(148, 30);
            this.Saper.Name = "Saper";
            this.Saper.Size = new System.Drawing.Size(446, 20);
            this.Saper.TabIndex = 0;
            this.Saper.TextChanged += new System.EventHandler(this.Saper_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(22, 83);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(709, 416);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("file:///\\Users\\Julian Machowski\\source\\repos\\Saper\\Saper\\bin\\Debug\\help.html", System.UriKind.Absolute);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 540);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Saper);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Saper;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}