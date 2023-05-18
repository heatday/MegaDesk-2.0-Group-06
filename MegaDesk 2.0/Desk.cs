using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Muzo
{
    public class Desk
    {
        // FIELDS
        private double depth;
        private double width;
        private double drawerCount;
        private string material;

        public const int MinWidth = 24;
        public const int MaxWidth = 96;
        public const int MinDepth = 12;
        public const int MaxDepth = 48;
        // PROPERTIES
        public double Depth { get { return depth; } }
        public double Width { get { return width; } }
        public double DrawerCount { get { return drawerCount; } }
        public String Material { get { return material; } }
        // CONSTRUCTOR
        public Desk(double depth, double width, double drawerCount, string material)
        {
            this.depth = depth;
            this.width = width;
            this.drawerCount = drawerCount;
            this.material = material.TrimEnd();
        }
    }

    public enum SurfaceMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }
}