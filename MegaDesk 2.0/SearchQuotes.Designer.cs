namespace MegaDesk_Muzo
{
    partial class SearchQuotes
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
            this.SurMaterials = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(75, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surface Materials:";
            // 
            // SurMaterials
            // 
            this.SurMaterials.FormattingEnabled = true;
            this.SurMaterials.Location = new System.Drawing.Point(251, 42);
            this.SurMaterials.Name = "SurMaterials";
            this.SurMaterials.Size = new System.Drawing.Size(121, 24);
            this.SurMaterials.TabIndex = 1;
            // Populate the SurMaterials ComboBox with enum names
            SurMaterials.Items.Add(Desk.DesktopMaterial.Laminate.ToString());
            SurMaterials.Items.Add(Desk.DesktopMaterial.Oak.ToString());
            SurMaterials.Items.Add(Desk.DesktopMaterial.Rosewood.ToString());
            SurMaterials.Items.Add(Desk.DesktopMaterial.Veneer.ToString());
            SurMaterials.Items.Add(Desk.DesktopMaterial.Pine.ToString());
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SurMaterials);
            this.Controls.Add(this.label1);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout(); 

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SurMaterials;
    }
}