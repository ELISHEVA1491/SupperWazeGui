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
using System.Windows.Shapes;
using SupperWazeBL;

namespace SupperWazeGUI.Forms
{
    /// <summary>
    /// Interaction logic for TheSoppingMenu.xaml
    /// </summary>
    public partial class TheSoppingMenu : Window
    {
        FunctionBL funBL = new FunctionBL();
        ProductListInOrder pl1 = new ProductListInOrder();
        List<string> l1;
        public static List<SupperWazeENTITIES.LastShopping> listToBuy = new List<SupperWazeENTITIES.LastShopping>();
        int client_code;

        public TheSoppingMenu(int code_Client)
        {
            InitializeComponent();
            client_code = code_Client;
        }

        private void ice_cream_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "גלידות";
            FillProducts("ice_creams");
        }

        private void cleaning_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "ניקיון";
            FillProducts("cleaning");
        }

        private void cakes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "בישול ואפיה";
            FillProducts("cakes");
        }

        private void bread_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "לחם ומאפים";
            FillProducts("bread");
        }

        private void snacks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "חטיפים";
            FillProducts("snacks");
        }

        private void cans_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "שימורים";
            FillProducts("cans");
        }

        private void fruit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "פירות וירקות";
            FillProducts("fruit_veg");
        }

        private void frozen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "קפואים";
            FillProducts("frozen");
        }

        private void milk_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "חלב וביצים";
            FillProducts("milk");
        }

        private void dishes_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "חד פעמי";
            FillProducts("dishes");
        }

        private void wines_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "יין ואלכוהול";
            FillProducts("wines");
        }

        private void babies_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DataContext = "פארם ותינוקות";
            FillProducts("babies");
        }

        private void FillProducts(string department)
        {
            productsBoard.Children.Clear();
            GUI.Products_board_UC products_Board_UC = new GUI.Products_board_UC(department);
            productsBoard.Children.Add(products_Board_UC);
        }

        private void endBuying_MouseDown(object sender, MouseButtonEventArgs e)
        {
            foreach (var item in listToBuy)//מכיון שבהוספת המוצר והכמות לא הוכנס קוד הלקוח
            {
                item.ClientCode = client_code;
            }

            List<SupperWazeENTITIES.Product> list_of_products = new List<SupperWazeENTITIES.Product>();
            foreach (SupperWazeENTITIES.LastShopping item in Forms.TheSoppingMenu.listToBuy)
            {   //להכניס את כל פרטי המוצר לרשימה
                SupperWazeENTITIES.Product P = new SupperWazeENTITIES.Product();
                P = funBL.GetProductDetailsByCode(item.ProductCode);
                list_of_products.Add(P);
                //list_of_products.Add(new SupperWazeENTITIES.Product() { ProductDescription = functionBL.GetProductNameByProductCode(item.ProductCode), ProductLocationX = locationX });
            }
            //מזמנים את הפונקציה שמחזירה את הרשימה לפי סדר הקנייה
            List<SupperWazeBL.ProductListInOrder> list = funBL.ShoppingListInOrder(list_of_products);
            //מזמנים את הפונקציה שמחזירה את כל הנקודות בהם עלינו לעבור בקנייה זו
            List<string> points = new List<string>();
            points = funBL.DisplayRoute(list);

            /*foreach (SupperWazeBL.ProductListInOrder item in list)
            {
                list_of_products.Add(new SupperWazeENTITIES.Product() { ProductDescription = functionBL.GetProductNameByProductCode(item.DProduct.ProductCode) });
            }
            List<SupperWazeENTITIES.Product> listProducts = new List<SupperWazeENTITIES.Product>();
            */

            TheShoppingRoute theShoppingRoute = new TheShoppingRoute(list, points);
            theShoppingRoute.Show();

        }

        private void showCart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowCart showCart = new ShowCart();
            showCart.Show();
        }
    }
}
