using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupperWazeENTITIES
{
    public class Sales
    {
        public int SaleCode { get; set; }
        public int ProductCode { get; set; }
        public int MinimumNumberOfUnitsToBuy { get; set; }
        public int MinimumPurshasePricePerOffer { get; set; }
        public string SalePriceForUnit { get; set; }
        public string SalePriceForAmount { get; set; }
    }
}
