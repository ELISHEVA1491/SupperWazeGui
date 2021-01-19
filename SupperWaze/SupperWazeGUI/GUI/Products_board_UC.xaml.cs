using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SupperWazeGUI.GUI
{
    /// <summary>
    /// Interaction logic for Products_board_UC.xaml
    /// </summary>
    public partial class Products_board_UC : UserControl
    {
        List<SupperWazeENTITIES.Product> listProductPerPlatoon;
        string platoon;
        int index = 0;
        int count;

        public Products_board_UC(string platoon)
        {
            InitializeComponent();
            listProductPerPlatoon = new List<SupperWazeENTITIES.Product>();
            productsBoard.Children.Clear();
            SupperWazeBL.FunctionBL functionBL = new SupperWazeBL.FunctionBL();
            listProductPerPlatoon = functionBL.GetSProductPlatoon(platoon);
            this.platoon = platoon;
            this.index = 0;
            Fill_6_Products();
        }

        private void prevBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.index = index - count - 6;
            Fill_6_Products();
            enableNextAndPrev();
        }

        private void nextBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // this.index++;
            Fill_6_Products();
            enableNextAndPrev();
        }

        private void Fill_6_Products()
        {
            productsBoard.Children.Clear();
            if (index < 0) index = 0;
            count = 0;
            Product_UC product;
            for (int i = 1; i < 6 && index < listProductPerPlatoon.Count; i += 2)
            {
                int num = listProductPerPlatoon[index].ProductCode;
                string des = listProductPerPlatoon[index].ProductDescription;
                double price = listProductPerPlatoon[index].ProductPrice;
                product = new Product_UC(num, des, price, platoon);
                this.index++;
                product.SetValue(Grid.RowProperty, 0);
                product.SetValue(Grid.ColumnProperty, i);
                // product.SetValue(HeightProperty, 285.0);
                //  product.SetValue(WidthProperty, 181.0);
                //  product.SetValue(MarginProperty, new Thickness(2, 2, 2, 2));
                productsBoard.Children.Add(product);
                count++;

                if (index < listProductPerPlatoon.Count)
                {
                    product = new Product_UC(listProductPerPlatoon[index].ProductCode, listProductPerPlatoon[index].ProductDescription, listProductPerPlatoon[index].ProductPrice, platoon);
                    this.index++;
                    product.SetValue(Grid.RowProperty, 2);
                    product.SetValue(Grid.ColumnProperty, i);
                    // product.SetValue(HeightProperty, 285.0);
                    //  product.SetValue(WidthProperty, 181.0);
                    //  product.SetValue(MarginProperty, new Thickness(2, 2, 2, 2));
                    productsBoard.Children.Add(product);
                    count++;
                }
            }
            enableNextAndPrev();
        }

        private void enableNextAndPrev()
        {
            if(index<listProductPerPlatoon.Count)
            {
                prevBTN.IsEnabled = true;
                nextBTN.IsEnabled = true;
            }
            
            if (index == listProductPerPlatoon.Count)
            {
                nextBTN.IsEnabled = false;
                prevBTN.IsEnabled = true;
            }
            else
                if (index >= 0 && index <= 6)
            {
                prevBTN.IsEnabled = false;
                nextBTN.IsEnabled = true;
            }
        }
    }
}
