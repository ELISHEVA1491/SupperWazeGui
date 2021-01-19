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

namespace SupperWazeGUI.Forms
{
    /// <summary>
    /// Interaction logic for StartShoppingMessage.xaml
    /// </summary>
    public partial class StartShoppingMessage : Window
    {
        int customerCode;

        public StartShoppingMessage(int code_customer,bool is_new)
        {
            InitializeComponent();
            if(is_new==false)
            {
                titleLBL.Content = "זיהוי בוצע בהצלחה, מיד נתחיל בקנייה";
                
            }
            this.customerCode = code_customer;
            this.DataContext = "הקוד שלך הוא" +":"+" "+ customerCode;
        }

        private void okBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TheSoppingMenu theSoppingMenu = new TheSoppingMenu(customerCode);
            theSoppingMenu.Show();
        }

        private void last_shopping_LBL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Forms.TheSoppingMenu.listToBuy = פונקציה שמחזירה קניה של לקוח   //customerCode
         
            //TheShoppingRoute route = new TheShoppingRoute();
            //route.Show();
        }
    }
}
