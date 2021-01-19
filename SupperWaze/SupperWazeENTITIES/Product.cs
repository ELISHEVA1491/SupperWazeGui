using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupperWazeENTITIES
{
    public class Product
    {
        public int ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductLocationX { get; set; }
        public string ProductLocationY { get; set; } 
        public string ProductLocationSide { get; set; } 
        public double ProductPrice { get; set; }
        public string SaleCode { get; set; }
        public string ProductCompany { get; set; }
        public int UnitsInStock { get; set; }
        public string ProductCapacity { get; set; }
        public int ClassCode { get; set; }
        public int PlatoonCode { get; set; }
    }
}
