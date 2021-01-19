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
using System.Text.RegularExpressions;
using SupperWazeBL;

namespace SupperWazeGUI.Forms
{
    /// <summary>
    /// Interaction logic for CustomerMenu.xaml
    /// </summary>
    public partial class CustomerMenu : Window
    {
        SupperWazeBL.FunctionBL FunctionBL = new SupperWazeBL.FunctionBL();
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void okBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (IsCellPhone(telClient.Text) == false)
                MessageBox.Show("טלפון לא תקין");
            else
            {
                int code = FunctionBL.GetClientCodeByClientPhone(telClient.Text);
                if (code != -1)
                {
                    StartShoppingMessage startShopping = new StartShoppingMessage(code,false);
                    startShopping.Show();
                }
                else
                {
                    MessageBox.Show("מספר הטלפון אינו שמור במערכת", "טעות", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK, MessageBoxOptions.RightAlign);
                }
            }
        }

        private void saveNewCustomerBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (nameNewClient.Text != "" && addressNewClient.Text != "" && telNewClient.Text != "")
            {
                if (IsCellPhone(telNewClient.Text) == false || IsHebrew(nameNewClient.Text) == false)
                    MessageBox.Show("וודא שהפרטים שהזנת תקינים");
                else
                {
                    int code = FunctionBL.AddClientAndGetClientCode(nameNewClient.Text, addressNewClient.Text, telNewClient.Text);
                    StartShoppingMessage startShopping = new StartShoppingMessage(code,true);
                    startShopping.Show();
                }
            }
            else
            {
                MessageBox.Show("אנא מלא את כל הפרטים", "שים לב", MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK, MessageBoxOptions.RightAlign);
            }
        }

        //אותיות בלבד
       private bool IsHebrew(string word)
        {
            string pattern = @"\b[א-ת-\s ]+$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(word);

        }

        //פלאפון
       private bool IsCellPhone(string tel)
        {
            string pattern = @"\b05[0 2 4 6 7 8 3][2-9]\d{6}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(tel);
        }
    }
}
