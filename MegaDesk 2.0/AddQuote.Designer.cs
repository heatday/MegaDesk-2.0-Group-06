using System;

namespace MegaDesk_Muzo
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DepthNum = new System.Windows.Forms.NumericUpDown();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.WidthNum = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.DrawersNum = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DelCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SurCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.getquotebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(171, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Quote";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(120, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(319, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 29);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DepthNum);
            this.groupBox1.Controls.Add(this.DepthLabel);
            this.groupBox1.Controls.Add(this.WidthNum);
            this.groupBox1.Controls.Add(this.WidthLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(29, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(240, 120);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Size";
            // 
            // DepthNum
            // 
            this.DepthNum.Location = new System.Drawing.Point(105, 60);
            this.DepthNum.Margin = new System.Windows.Forms.Padding(2);
            this.DepthNum.Name = "DepthNum";
            this.DepthNum.Size = new System.Drawing.Size(90, 20);
            this.DepthNum.TabIndex = 7;
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthLabel.Location = new System.Drawing.Point(33, 60);
            this.DepthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(60, 20);
            this.DepthLabel.TabIndex = 5;
            this.DepthLabel.Text = "Depth:";
            // 
            // WidthNum
            // 
            this.WidthNum.Location = new System.Drawing.Point(104, 28);
            this.WidthNum.Margin = new System.Windows.Forms.Padding(2);
            this.WidthNum.Name = "WidthNum";
            this.WidthNum.Size = new System.Drawing.Size(90, 20);
            this.WidthNum.TabIndex = 6;
            // 
            // WidthLabel
            // 
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(33, 27);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(68, 19);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width:";
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersLabel.Location = new System.Drawing.Point(4, 24);
            this.DrawersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(160, 20);
            this.DrawersLabel.TabIndex = 5;
            this.DrawersLabel.Text = "Number of Drawers:";
            // 
            // DrawersNum
            // 
            this.DrawersNum.Location = new System.Drawing.Point(176, 27);
            this.DrawersNum.Margin = new System.Windows.Forms.Padding(2);
            this.DrawersNum.Name = "DrawersNum";
            this.DrawersNum.Size = new System.Drawing.Size(42, 20);
            this.DrawersNum.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DelCombo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.SurCombo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DrawersLabel);
            this.groupBox2.Controls.Add(this.DrawersNum);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(319, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(250, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desk Features";
            // 
            // DelCombo
            // 
            this.DelCombo.FormattingEnabled = true;
            this.DelCombo.Location = new System.Drawing.Point(155, 88);
            this.DelCombo.Margin = new System.Windows.Forms.Padding(2);
            this.DelCombo.Name = "DelCombo";
            this.DelCombo.Size = new System.Drawing.Size(92, 21);
            this.DelCombo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rush:";
            // 
            // SurCombo
            // 
            this.SurCombo.FormattingEnabled = true;
            this.SurCombo.Location = new System.Drawing.Point(155, 57);
            this.SurCombo.Margin = new System.Windows.Forms.Padding(2);
            this.SurCombo.Name = "SurCombo";
            this.SurCombo.Size = new System.Drawing.Size(92, 21);
            this.SurCombo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Surface Materials:";
            // 
            // getquotebutton
            // 
            this.getquotebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.getquotebutton.Location = new System.Drawing.Point(134, 300);
            this.getquotebutton.Margin = new System.Windows.Forms.Padding(2);
            this.getquotebutton.Name = "getquotebutton";
            this.getquotebutton.Size = new System.Drawing.Size(150, 38);
            this.getquotebutton.TabIndex = 9;
            this.getquotebutton.Text = "Get Quote";
            this.getquotebutton.UseVisualStyleBackColor = true;
            this.getquotebutton.Click += new System.EventHandler(this.getquotebutton_Click_1);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cancelbutton.Location = new System.Drawing.Point(319, 300);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(150, 38);
            this.cancelbutton.TabIndex = 10;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.getquotebutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawersNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void cancelbutton_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown WidthNum;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.NumericUpDown DepthNum;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.NumericUpDown DrawersNum;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox DelCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SurCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getquotebutton;
        private System.Windows.Forms.Button cancelbutton;
    }
}