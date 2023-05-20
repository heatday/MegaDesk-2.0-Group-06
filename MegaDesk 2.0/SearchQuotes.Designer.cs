namespace MegaDesk_Muzo
{
    partial class SearchQuotes
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView DataGridView = new System.Windows.Forms.DataGridView
        {
            AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill,
            ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize,
            Location = new System.Drawing.Point(12, 80),
            Name = "DataGridView",
            Size = new System.Drawing.Size(776, 358),
            TabIndex = 2
        };



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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(86, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Materials";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SurMaterials
            // 
            //this.SurMaterials.FormattingEnabled = true;
            //this.SurMaterials.Items.AddRange(new object[] {
            //"All Materials",
            //"Laminate",
            //"Oak",
            //"Rosewood",
            //"Veneer",
            //"Pine"});



            this.SurMaterials.Items.AddRange(new object[] {
            "All Materials",
            SurfaceMaterial.Laminate.ToString(),
            SurfaceMaterial.Oak.ToString(),
            SurfaceMaterial.Rosewood.ToString(),
            SurfaceMaterial.Veneer.ToString(),
            SurfaceMaterial.Pine.ToString()});
            this.SurMaterials.Location = new System.Drawing.Point(251, 42);
            this.SurMaterials.Name = "SurMaterials";
            this.SurMaterials.Size = new System.Drawing.Size(121, 24);
            this.SurMaterials.TabIndex = 1;
            this.SurMaterials.SelectedIndexChanged += new System.EventHandler(this.SurMaterials_SelectedIndexChanged);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(12, 80);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.Size = new System.Drawing.Size(776, 358);
            this.DataGridView.TabIndex = 2;
            this.Controls.Add(this.DataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SurMaterials;


    }
}