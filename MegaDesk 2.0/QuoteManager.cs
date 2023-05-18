using System;
using System.Collections.Generic;
using System.IO;


namespace MegaDesk_Muzo
{
    public class QuoteManager
    {
        // FIELDS
        private List<DeskQuote> quotes = new List<DeskQuote>();

        public List<DeskQuote> Quotes
        {
            get { return quotes; }
        }

        // METHODS
        public void AddQuote(double depth, double width, double drawerCount, string material, string customerName, string rushType)
        {
            Desk desk = new Desk(depth, width, drawerCount, material);
            DeskQuote quote = new DeskQuote(desk, customerName, rushType);
            quotes.Add(quote);
        }
        public void AddQuote(double depth, double width, double drawerCount, string material, string customerName, double cost, string rushType, string date)
        {
            Desk desk = new Desk(depth, width, drawerCount, material);
            DeskQuote quote = new DeskQuote(desk, customerName, cost, rushType, date);
            quotes.Add(quote);
        }

        public void SaveQuote()
        {
            using (StreamWriter io = new StreamWriter("C:\\Users\\offic\\Documents\\GitHub\\MegaDesk-2.0-Group-06\\MegaDesk 2.0\\Quotes.txt", true))
            {
                DeskQuote quote = quotes[quotes.Count - 1];
                io.WriteLine($"{quote.CustomerName},{quote.Cost},{quote.RushType},{quote.Desk.Depth},{quote.Desk.Width},{quote.Desk.DrawerCount},{quote.Desk.Material},{quote.Date}");
                
            }
        }
    }
}
