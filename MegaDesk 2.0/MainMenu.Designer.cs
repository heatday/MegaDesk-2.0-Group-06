﻿using System;

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
            this.ViewFirstForm.Location = new System.Drawing.Point(42, 24);
            this.ViewFirstForm.Margin = new System.Windows.Forms.Padding(2);
            this.ViewFirstForm.Name = "ViewFirstForm";
            this.ViewFirstForm.Size = new System.Drawing.Size(156, 51);
            this.ViewFirstForm.TabIndex = 0;
            this.ViewFirstForm.Text = "&Add New Quote";
            this.ViewFirstForm.UseVisualStyleBackColor = true;
            this.ViewFirstForm.Click += new System.EventHandler(this.ViewFirstFormClick);
            // 
            // ViewSecondForm
            // 
            this.ViewSecondForm.Location = new System.Drawing.Point(42, 97);
            this.ViewSecondForm.Margin = new System.Windows.Forms.Padding(2);
            this.ViewSecondForm.Name = "ViewSecondForm";
            this.ViewSecondForm.Size = new System.Drawing.Size(156, 53);
            this.ViewSecondForm.TabIndex = 1;
            this.ViewSecondForm.Text = "&View Quotes";
            this.ViewSecondForm.UseVisualStyleBackColor = true;
            this.ViewSecondForm.Click += new System.EventHandler(this.ViewSecondForm_Click);
            // 
            // ViewThirdForm
            // 
            this.ViewThirdForm.Location = new System.Drawing.Point(42, 176);
            this.ViewThirdForm.Margin = new System.Windows.Forms.Padding(2);
            this.ViewThirdForm.Name = "ViewThirdForm";
            this.ViewThirdForm.Size = new System.Drawing.Size(156, 54);
            this.ViewThirdForm.TabIndex = 2;
            this.ViewThirdForm.Text = "&Search Quotes";
            this.ViewThirdForm.UseVisualStyleBackColor = true;
            this.ViewThirdForm.Click += new System.EventHandler(this.ViewThirdFormClick);
            // 
            // ViewFourthForm
            // 
            this.ViewFourthForm.Location = new System.Drawing.Point(42, 258);
            this.ViewFourthForm.Margin = new System.Windows.Forms.Padding(2);
            this.ViewFourthForm.Name = "ViewFourthForm";
            this.ViewFourthForm.Size = new System.Drawing.Size(156, 54);
            this.ViewFourthForm.TabIndex = 3;
            this.ViewFourthForm.Text = "E&xit";
            this.ViewFourthForm.UseVisualStyleBackColor = true;
            this.ViewFourthForm.Click += new System.EventHandler(this.ViewFourthForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewFourthForm);
            this.Controls.Add(this.ViewThirdForm);
            this.Controls.Add(this.ViewSecondForm);
            this.Controls.Add(this.ViewFirstForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = " Desk ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

    private void ViewFirstFormClick(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote(ref QuoteManager, this);
            addQuoteForm.Show();
            this.Hide();
        }

        private void ViewSecondFormClick(object sender, EventArgs e)
        {
            DisplayQuote displayQuoteForm = new DisplayQuote(ref QuoteManager, this);
            displayQuoteForm.Show();
            this.Hide();
        }


        private void ViewThirdFormClick(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes(QuoteManager);
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

