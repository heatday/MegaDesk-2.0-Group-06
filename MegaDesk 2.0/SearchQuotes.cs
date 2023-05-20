using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Muzo
{
    public partial class SearchQuotes : Form
    {
        private QuoteManager quoteManager;

        public SearchQuotes(QuoteManager quoteManager)
        {
            InitializeComponent();
            this.quoteManager = quoteManager;
            // Instantiate the DataGridView control

            DataGridView.DataError += DataGridView_DataError;

        }

        private void SurMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaterial = SurMaterials.SelectedItem.ToString();
            List<DeskQuote> filteredQuotes;

            if (selectedMaterial == "All Materials")
            {
                filteredQuotes = quoteManager.Quotes;
            }
            else
            {
                filteredQuotes = quoteManager.Quotes
                    .Where(quote => string.Equals(quote.Desk.Material, selectedMaterial, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            // Clear existing columns
            DataGridView.Columns.Clear();

            // Set data source
            DataGridView.DataSource = filteredQuotes;
        }





        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Handle the error by providing a default value for the cell
            if (e.ColumnIndex == DataGridView.Columns["SurfaceMaterial"].Index)
            {
                e.ThrowException = false;
                e.Cancel = false;

                // Get the original SurfaceMaterial value from the DeskQuote object
                DeskQuote quote = DataGridView.Rows[e.RowIndex].DataBoundItem as DeskQuote;
                SurfaceMaterial originalMaterial = quote?.Desk.SurfaceMaterial ?? SurfaceMaterial.Oak;

                DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = originalMaterial;
            }
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}