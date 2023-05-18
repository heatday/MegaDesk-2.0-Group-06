using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Muzo
{
    public class DeskQuote
    {
        // FIELDS
        private Desk desk;
        private double cost;
        private string customerName;
        private string rushType;
        private string date;
        private DateTime dateTime;
        // PROPERTIES
        public Desk Desk { get { return desk; } }
        public double Cost { get { return cost; } }
        public string CustomerName { get { return customerName; } }
        public string RushType { get { return rushType; } }
        public string Date { get { return date; } }
        // CONSTRUCTOR
        public DeskQuote(Desk desk, string customerName, string rushType)
        {
            this.desk = desk;
            this.customerName = customerName;
            this.rushType = rushType;
            dateTime = DateTime.Now;
            this.date = dateTime.ToShortDateString();
            double surfaceArea = (desk.Width * desk.Depth);
            double materialCost = 0;
            double rushCost = 0;
            switch (rushType)
            {
                case "3 Days":
                    if (surfaceArea < 1000)
                        rushCost = 60;
                    else if (surfaceArea >= 1000 && surfaceArea < 2000)
                        rushCost = 70;
                    else
                        rushCost = 80;
                    break;
                case "5 Days":
                    if (surfaceArea < 1000)
                        rushCost = 40;
                    else if (surfaceArea >= 1000 && surfaceArea < 2000)
                        rushCost = 50;
                    else
                        rushCost = 60;
                    break;
                case "7 Days":
                    if (surfaceArea < 1000)
                        rushCost = 30;
                    else if (surfaceArea >= 1000 && surfaceArea < 2000)
                        rushCost = 35;
                    else
                        rushCost = 40;
                    break;
                default:
                    rushCost = 0;
                    break;
            }
            switch (Desk.Material.ToLower())
            {
                case "oak":
                    materialCost = (double)SurfaceMaterial.Oak;
                    break;
                case "laminate":
                    materialCost = (double)SurfaceMaterial.Laminate;
                    break;
                case "pine":
                    materialCost = (double)SurfaceMaterial.Pine;
                    break;
                case "rosewood":
                    materialCost = (double)SurfaceMaterial.Rosewood;
                    break;
                case "veneer":
                    materialCost = (double)SurfaceMaterial.Veneer;
                    break;
            }
            if (surfaceArea > 1000)
                this.cost += (double)Price.SurfaceArea * (surfaceArea - 1000);
            this.cost += (double)Price.Base + ((double)Price.Drawer * Desk.DrawerCount) + materialCost + rushCost;

        }
        public DeskQuote(Desk desk, string customerName, double cost, string rushType, string date)
        {
            this.desk = desk;
            this.customerName = customerName;
            this.rushType = rushType;
            this.cost = cost;
            this.date = date;
        }
        public bool ContainsTerm(string searchTerm)
        {
            // Perform the search logic based on your requirements
            // Example: Check if the search term exists in CustomerName or QuoteText
            if (CustomerName.Contains(searchTerm))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public enum Price
    {
        Base = 200,
        SurfaceArea = 1,
        Drawer = 50
    }
}

