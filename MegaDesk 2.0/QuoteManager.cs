using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Muzo
{
    public class QuoteManager
    {
        private List<DeskQuote> quotes;

        public List<DeskQuote> Quotes
        {
            get { return quotes; }
        }

        public QuoteManager()
        {
            if (File.Exists("C:\\Users\\offic\\Documents\\GitHub\\MegaDesk-2.0-Group-06\\MegaDesk 2.0\\Quotes.json"))
            {
                string json = File.ReadAllText("C:\\Users\\offic\\Documents\\GitHub\\MegaDesk-2.0-Group-06\\MegaDesk 2.0\\Quotes.json");
                dynamic data = JsonConvert.DeserializeObject(json);
                foreach (var quote in data)
                {
                    AddQuote((double)quote.Desk.Depth, (double)quote.Desk.Width, (int)quote.Desk.DrawerCount, (string)quote.Desk.Material, (string)quote.CustomerName, (double)quote.Cost, (string)quote.RushType, (string)quote.Date);
                }
            }
            else
            {
                quotes = new List<DeskQuote>(); // Initialize the quotes list if the file doesn't exist
            }
        }

        public void AddQuote(double depth, double width, int drawerCount, string material, string customerName, string rushType)
        {
            if (quotes == null) // Check if quotes list is null
                quotes = new List<DeskQuote>(); // Instantiate the quotes list if null

            Desk desk = new Desk(depth, width, drawerCount, material);
            DeskQuote quote = new DeskQuote(desk, customerName, rushType);
            quotes.Add(quote);
        }

        public void AddQuote(double depth, double width, int drawerCount, string material, string customerName, double cost, string rushType, string date)
        {
            if (quotes == null) // Check if quotes list is null
                quotes = new List<DeskQuote>(); // Instantiate the quotes list if null

            Desk desk = new Desk(depth, width, drawerCount, material);
            DeskQuote quote = new DeskQuote(desk, customerName, cost, rushType, date);
            quotes.Add(quote);
        }

        public void SaveQuote()
        {
            string json = JsonConvert.SerializeObject(quotes);
            File.WriteAllText("C:\\Users\\offic\\Documents\\GitHub\\MegaDesk-2.0-Group-06\\MegaDesk 2.0\\Quotes.json", json);
        }
    }
}
