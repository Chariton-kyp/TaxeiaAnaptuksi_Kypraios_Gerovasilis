﻿namespace TaxeiaAnaptuksi_Gerovasilis_Kypraios
{
    partial class Video80
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVideoLink = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.webVideo = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Videolink";
            // 
            // txtVideoLink
            // 
            this.txtVideoLink.Location = new System.Drawing.Point(285, 90);
            this.txtVideoLink.Name = "txtVideoLink";
            this.txtVideoLink.Size = new System.Drawing.Size(400, 22);
            this.txtVideoLink.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(700, 90);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // webVideo
            // 
            this.webVideo.Location = new System.Drawing.Point(28, 119);
            this.webVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webVideo.Name = "webVideo";
            this.webVideo.Size = new System.Drawing.Size(747, 292);
            this.webVideo.TabIndex = 3;
            this.webVideo.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webVideo_DocumentCompleted);
            // 
            // Video80
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webVideo);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtVideoLink);
            this.Controls.Add(this.label1);
            this.Name = "Video80";
            this.Text = "Video80";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVideoLink;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.WebBrowser webVideo;
    }
}