using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_Muzo
{
    public partial class MainMenu : Form
    {
        QuoteManager QuoteManager = new QuoteManager();
        public MainMenu()
        {
            InitializeComponent();
            string[] quotes = File.ReadAllLines("C:\\Users\\offic\\Documents\\GitHub\\MegaDesk-2.0-Group-06\\MegaDesk 2.0\\Quotes.txt");
            foreach (string quote in quotes)
            {
                string[] data = quote.Split(',');
                QuoteManager.AddQuote(double.Parse(data[3]), double.Parse(data[4]), int.Parse(data[5]), data[6], data[0], double.Parse(data[1]), data[2], data[7]);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void ViewSecondForm_Click(object sender, EventArgs e)
        {
            DisplayQuote addQuoteForm = new DisplayQuote(ref QuoteManager, this);
            addQuoteForm.Show();
            this.Hide();
        }
    }
}
