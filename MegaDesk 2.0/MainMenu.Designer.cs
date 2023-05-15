using System;

namespace MegaDesk_Muzo
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ViewFirstForm = new System.Windows.Forms.Button();
            this.ViewSecondForm = new System.Windows.Forms.Button();
            this.ViewThirdForm = new System.Windows.Forms.Button();
            this.ViewFourthForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewFirstForm
            // 
            this.ViewFirstForm.Location = new System.Drawing.Point(56, 30);
            this.ViewFirstForm.Name = "ViewFirstForm";
            this.ViewFirstForm.Size = new System.Drawing.Size(208, 63);
            this.ViewFirstForm.TabIndex = 0;
            this.ViewFirstForm.Text = "&Add New Quote";
            this.ViewFirstForm.UseVisualStyleBackColor = true;
            this.ViewFirstForm.Click += new System.EventHandler(this.ViewFirstFormClick);
            // 
            // ViewSecondForm
            // 
            this.ViewSecondForm.Location = new System.Drawing.Point(56, 119);
            this.ViewSecondForm.Name = "ViewSecondForm";
            this.ViewSecondForm.Size = new System.Drawing.Size(208, 65);
            this.ViewSecondForm.TabIndex = 1;
            this.ViewSecondForm.Text = "&View Quotes";
            this.ViewSecondForm.UseVisualStyleBackColor = true;
            // 
            // ViewThirdForm
            // 
            this.ViewThirdForm.Location = new System.Drawing.Point(56, 217);
            this.ViewThirdForm.Name = "ViewThirdForm";
            this.ViewThirdForm.Size = new System.Drawing.Size(208, 67);
            this.ViewThirdForm.TabIndex = 2;
            this.ViewThirdForm.Text = "&Search Quotes";
            this.ViewThirdForm.UseVisualStyleBackColor = true;
            // 
            // ViewFourthForm
            // 
            this.ViewFourthForm.Location = new System.Drawing.Point(56, 318);
            this.ViewFourthForm.Name = "ViewFourthForm";
            this.ViewFourthForm.Size = new System.Drawing.Size(208, 67);
            this.ViewFourthForm.TabIndex = 3;
            this.ViewFourthForm.Text = "E&xit";
            this.ViewFourthForm.UseVisualStyleBackColor = true;
            this.ViewFourthForm.Click += new System.EventHandler(this.ViewFourthForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(421, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewFourthForm);
            this.Controls.Add(this.ViewThirdForm);
            this.Controls.Add(this.ViewSecondForm);
            this.Controls.Add(this.ViewFirstForm);
            this.Name = "MainMenu";
            this.Text = " Desk ";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

    private void ViewFirstFormClick(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();
            this.Hide();
        }

        private void ViewSecondFormClick(object sender, EventArgs e)
        {
            DisplayQuote displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Show();
        }


        private void ViewThirdFormClick(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Show();
        }



        private void ViewFourthForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private System.Windows.Forms.Button ViewFirstForm;
        private System.Windows.Forms.Button ViewSecondForm;
        private System.Windows.Forms.Button ViewThirdForm;
        private System.Windows.Forms.Button ViewFourthForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

