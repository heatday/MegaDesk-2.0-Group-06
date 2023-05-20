using System;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_Muzo
{
    public partial class MainMenu : Form
    {
        public static int[] RushCost;
        QuoteManager QuoteManager = new QuoteManager();
        public MainMenu()
        {
            InitializeComponent();
            string[] prices = File.ReadAllLines("C:\\Users\\offic\\Documents\\GitHub\\MegaDesk-2.0-Group-06\\MegaDesk 2.0\\RushCost.txt");
            RushCost = new int[prices.Length];
            for (int i = 0; i < prices.Length; i++)
            {
                RushCost[i] = int.Parse(prices[i]);
            }

        }

        private void ViewSecondForm_Click(object sender, EventArgs e)
        {
            DisplayQuote addQuoteForm = new DisplayQuote(ref QuoteManager, this);
            addQuoteForm.Show();
            this.Hide();
        }
    }
}
