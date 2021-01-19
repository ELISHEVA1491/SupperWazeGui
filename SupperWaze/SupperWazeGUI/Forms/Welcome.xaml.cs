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
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void ManagerBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Show();
            
        }

        private void CustomerBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            customerMenu.Show();
            this.Close();
        }
    }
}
