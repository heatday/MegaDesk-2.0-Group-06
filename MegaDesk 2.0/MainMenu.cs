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
