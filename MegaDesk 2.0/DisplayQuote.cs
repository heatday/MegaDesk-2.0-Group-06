using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Muzo
{
    public partial class DisplayQuote : Form
    {
        private QuoteManager quoteManager;
        private Form mainMenu;
        public DisplayQuote(ref QuoteManager quoteManager, Form mainMenu)
        {
            this.quoteManager = quoteManager;
            this.mainMenu = mainMenu;
            InitializeComponent();
            LoadQuotesIntoDataGridView();

        }

        private void LoadQuotesIntoDataGridView()
        {
            DataGridView.Rows.Clear(); // Clear existing rows

            foreach (DeskQuote quote in quoteManager.Quotes)
            {
                int rowIndex = DataGridView.Rows.Add(); // Add a new row

                // Access the newly added row
                DataGridViewRow row = DataGridView.Rows[rowIndex];

                // Assign the components of the Quote to specific columns
                row.Cells["Column1"].Value = quote.CustomerName;
                row.Cells["Column3"].Value = $"${Math.Round(quote.Cost, 2)}";
                row.Cells["Column4"].Value = quote.RushType;
                row.Cells["Column5"].Value = $"{quote.Desk.Depth} in";
                row.Cells["Column6"].Value = $"{quote.Desk.Width} in";
                row.Cells["Column7"].Value = quote.Desk.DrawerCount;
                row.Cells["Column8"].Value = !string.IsNullOrEmpty(quote.Desk.Material) && quote.Desk.Material.Length > 0
                ? $"{char.ToUpper(quote.Desk.Material[0])}{quote.Desk.Material.Substring(1)}"
    :           string.Empty;
                row.Cells["Column2"].Value = quote.Date;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu.Show();
        }
    }
}
