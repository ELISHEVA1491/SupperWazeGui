using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SupperWazeGUI.Forms
{
    /// <summary>
    /// Interaction logic for ShowCart.xaml
    /// </summary>
    public partial class ShowCart : Window
    {
        public static ObservableCollection<SupperWazeENTITIES.Product> list_of_products =  new ObservableCollection<SupperWazeENTITIES.Product>();
        private SupperWazeBL.FunctionBL functionBL = new SupperWazeBL.FunctionBL();
        public ShowCart()
        {
            InitializeComponent();

            totalPrice.DataContext = TotalPrice();
            list_of_products.Clear();

            foreach (SupperWazeENTITIES.LastShopping item in Forms.TheSoppingMenu.listToBuy)
            {
                list_of_products.Add(new SupperWazeENTITIES.Product() { ProductDescription = functionBL.GetProductNameByProductCode(item.ProductCode),ProductPrice= functionBL.GetProductPriceByProductCode(item.ProductCode) });// ProductCode = item.ProductCode });//פונקציה המקבלת שם מוצר לפי קוד
            }
            listOfPro.DataContext = list_of_products;
        }

        private double TotalPrice()
        {
            double sum = 0;
            foreach (SupperWazeENTITIES.LastShopping item in TheSoppingMenu.listToBuy)
            {
                sum += item.ProductAmount * functionBL.GetProductPriceByProductCode(item.ProductCode);//מחיר של מוצר* כמות
            }
            return sum;
        }

        private void addProductBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        public void RefrshList()
        {
            listOfPro.DataContext = list_of_products;
        }
    }
}
