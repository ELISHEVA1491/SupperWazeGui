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
    /// Interaction logic for ManagerLogin.xaml
    /// </summary>
    public partial class ManagerLogin : Window
    {
      //  SupperWazeBL.FunctionBL FunctionBL = new SupperWazeBL.FunctionBL();
        public ManagerLogin()
        {
            InitializeComponent();
        }
        private void okBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
          
            if (password.Password =="1234")
            {
                ManagerMenu managerMenu = new ManagerMenu();
                managerMenu.Show();
            }
            else
            {
                MessageBox.Show("סיסמה שגויה");
            }
        }
    }
}
