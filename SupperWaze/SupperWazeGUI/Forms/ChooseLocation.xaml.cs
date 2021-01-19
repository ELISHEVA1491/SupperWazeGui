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
    /// Interaction logic for ChooseLocation.xaml
    /// </summary>
    public partial class ChooseLocation : Window
    {
        string product_name = "";
        public ChooseLocation(string productName)
        {
            InitializeComponent();
            this.product_name = productName;
        }

        private void cleaningR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "1", "2");
        }

        private void cleaningL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "2", "10");
        }

        private void ice_creamR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "0", "2");
        }

        private void ice_creamL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "0", "2");
        }

        private void cakesR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "3", "2");
        }

        private void cakesL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "3", "2");
        }

        private void babiesL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "3", "10");
        }

        private void babiesR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "3", "10");
        }

        private void winesL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "2", "6");
        }

        private void winesR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "2", "6");
        }

        private void dishesL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "1", "6");
        }

        private void dishesR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "1", "6");
        }

        private void milkL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "0", "10");
        }

        private void milkR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "0", "10");
        }

        private void frozenL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "0", "6");
        }

        private void frozenR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "0", "6");
        }

        private void fruitL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "3", "6");
        }

        private void fruitR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "3", "6");
        }

        private void cansL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "2", "2");
        }

        private void cansR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "2", "2");
        }

        private void snacksL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "0", "10");
        }

        private void snacksR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "0", "10");
        }

        private void breadL_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("left", "2", "10");
        }

        private void breadR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UpdateLocation("right", "2", "10");
        }

        public void UpdateLocation(string side,string locationX,string locationY)
        {

            LocationMessage message = new LocationMessage(side, locationX, locationY, product_name);
            message.Show();
            this.Close();

        }
    }
}
