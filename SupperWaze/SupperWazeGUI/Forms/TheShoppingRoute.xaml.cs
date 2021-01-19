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
using SupperWazeBL;

namespace SupperWazeGUI.Forms
{
    /// <summary>
    /// Interaction logic for TheShoppingRoute.xaml
    /// </summary>
    public partial class TheShoppingRoute : Window
    {
        private ObservableCollection<SupperWazeENTITIES.Product> list_of_products = new ObservableCollection<SupperWazeENTITIES.Product>();
        private SupperWazeBL.FunctionBL functionBL = new SupperWazeBL.FunctionBL();
        private List<string> point;
    
        public TheShoppingRoute(List<SupperWazeBL.ProductListInOrder> list,List<string> points)
        {
            InitializeComponent();
           
            /*List<SupperWazeENTITIES.Product> list_of_products1 = new List<SupperWazeENTITIES.Product>();
            foreach (SupperWazeENTITIES.LastShopping item in Forms.TheSoppingMenu.listToBuy)
            {//להכניס את כל פרטי המוצר לרשימה
                string locationX = "";//פונקציה item.ProductCode
                list_of_products1.Add(new SupperWazeENTITIES.Product() { ProductDescription = functionBL.GetProductNameByProductCode(item.ProductCode), ProductLocationX = locationX });

            }
            //מזמנים את הפונקציה שמחזירה את הרשימה לפי סדר הקנייה
            List<SupperWazeBL.ProductListInOrder> list1 = functionBL.ShoppingListInOrder(list_of_products1);
            //מזמנים את הפונקציה שמחזירה את כל הנקודות בהם עלינו לעבור בקנייה זו
            point = functionBL.DisplayRoute(list1);*/
            foreach (SupperWazeBL.ProductListInOrder item in list)
            {
                if(item.DProduct.ProductCode != -1)
                   list_of_products.Add(new SupperWazeENTITIES.Product() { ProductDescription = item.DProduct.ProductDescription });
            }

            listOfPro.DataContext = list_of_products;
            

            GUI.Map map = new GUI.Map(list,points);
            for (int i = 0; i < points.Count - 1; i++)
            {
                map.HightOrangeLine(points[i],points[i+1]);
            }
            map.SetValue(Grid.RowProperty, 1);
            map.SetValue(HeightProperty, 530.0);
            map.SetValue(WidthProperty, 600.0);
            routeMap.Children.Add(map);
        }

        private void addProductBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void listOfPro_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
    }
}
