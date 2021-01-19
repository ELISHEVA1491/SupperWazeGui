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
    /// Interaction logic for LocationMessage.xaml
    /// </summary>
    public partial class LocationMessage : Window
    {
        SupperWazeBL.FunctionBL functionBL = new SupperWazeBL.FunctionBL();
        string side, locationX;
        int productCode, locationY;
        public LocationMessage(string side, string locationX, string locationY,string productName)
        {
            InitializeComponent();
            this.side = side;
            this.locationX = locationX;
            this.locationY =Convert.ToInt32( locationY);
            this.productCode =functionBL.GetProductCodeByProductName( productName);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            functionBL.UpdateProductLocation(productCode, locationX, (locationY+1).ToString(), side);
            MessageBox.Show("מוצר נוסף בהצלחה");
            this.Close();
        }

        private void middle_Click(object sender, RoutedEventArgs e)
        {
            functionBL.UpdateProductLocation(productCode, locationX, (locationY ).ToString(), side);
            MessageBox.Show("מוצר נוסף בהצלחה");
            this.Close();
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            functionBL.UpdateProductLocation(productCode, locationX, (locationY - 1).ToString(), side);
            MessageBox.Show("מוצר נוסף בהצלחה");
            this.Close();
        }
    }
}
