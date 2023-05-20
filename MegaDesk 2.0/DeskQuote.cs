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
        private string customerName;
        private string rushType;
        private string date;
        private double cost;
        private DateTime dateTime;
        // PROPERTIES
        public Desk Desk { get { return desk; } }
        public string CustomerName { get { return customerName; } }
        public SurfaceMaterial SurfaceMaterial { get; set; }
        public string RushType { get { return rushType; } }
        public double Cost { get { return cost; } }
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

            // Assign the SurfaceMaterial based on the material of the desk
            switch (desk.Material.ToLower())
            {
                case "oak":
                    desk.SurfaceMaterial = SurfaceMaterial.Oak;
                    break;
                case "laminate":
                    desk.SurfaceMaterial = SurfaceMaterial.Laminate;
                    break;
                case "pine":
                    desk.SurfaceMaterial = SurfaceMaterial.Pine;
                    break;
                case "rosewood":
                    desk.SurfaceMaterial = SurfaceMaterial.Rosewood;
                    break;
                case "veneer":
                    desk.SurfaceMaterial = SurfaceMaterial.Veneer;
                    break;
            }
            switch (rushType)
            {
                case "3 Days":
                    if (surfaceArea < 1000)
                        rushCost = MainMenu.RushCost[0];
                    else if (surfaceArea >= 1000 && surfaceArea < 2000)
                        rushCost = MainMenu.RushCost[1];
                    else
                        rushCost = MainMenu.RushCost[2];
                    break;
                case "5 Days":
                    if (surfaceArea < 1000)
                        rushCost = MainMenu.RushCost[3];
                    else if (surfaceArea >= 1000 && surfaceArea < 2000)
                        rushCost = MainMenu.RushCost[4];
                    else
                        rushCost = MainMenu.RushCost[5];
                    break;
                case "7 Days":
                    if (surfaceArea < 1000)
                        rushCost = MainMenu.RushCost[6];
                    else if (surfaceArea >= 1000 && surfaceArea < 2000)
                        rushCost = MainMenu.RushCost[7];
                    else
                        rushCost = MainMenu.RushCost[8];
                    break;
                default:
                    rushCost = 0;
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
            // Assign the SurfaceMaterial based on the material of the desk
            switch (desk.Material.ToLower())
            {
                case "oak":
                    desk.SurfaceMaterial = SurfaceMaterial.Oak;
                    break;
                case "laminate":
                    desk.SurfaceMaterial = SurfaceMaterial.Laminate;
                    break;
                case "pine":
                    desk.SurfaceMaterial = SurfaceMaterial.Pine;
                    break;
                case "rosewood":
                    desk.SurfaceMaterial = SurfaceMaterial.Rosewood;
                    break;
                case "veneer":
                    desk.SurfaceMaterial = SurfaceMaterial.Veneer;
                    break;
            }
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


