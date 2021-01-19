using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupperWazeDAL;
using SupperWazeENTITIES;
namespace SupperWazeBL
{
    public class ProductListInOrder
    {
        private int TransitionX;
        private int TransitionY;
        private Product product;//עצם מסוג מוצר// 

      
        public int DTransitionX
        {
            get { return this.TransitionX; }
            set { this.TransitionX = value; }
        }
        public int DTransitionY
        {
            get { return this.TransitionY; }
            set { this.TransitionY = value; }
        }
        public Product DProduct
        {
            get { return this.product; }
            set { this.product = value; }
        }

        public static implicit operator ProductListInOrder(List<ProductListInOrder> v)
        {
            throw new NotImplementedException();
        }
    }
}
