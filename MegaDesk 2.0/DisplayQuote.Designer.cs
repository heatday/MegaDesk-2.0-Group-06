using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;
using System;

namespace MegaDesk_Muzo
{
    partial class DisplayQuote
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
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(343, 383);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(119, 22);
            this.TimeBox.TabIndex = 0;
            this.Load += DisplayQuote_Load;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeBox);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TimeBox;
        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            // Set the current date in the TimeBox TextBox
            TimeBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

    }
    
}

