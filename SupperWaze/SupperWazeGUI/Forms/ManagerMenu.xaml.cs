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
    /// Interaction logic for ManagerMenu.xaml
    /// </summary>
    public partial class ManagerMenu : Window
    {
        SupperWazeBL.FunctionBL funBL = new SupperWazeBL.FunctionBL();
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            List<SupperWazeBL.Platoon>list=funBL.GetPlatoonTable();
            foreach (SupperWazeBL.Platoon item in list)
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = item.PlatoonName;
                platoonList.Items.Add(newItem);
            }
            AddProduct.Visibility = Visibility.Visible;
            DeleteProduct.Visibility = Visibility.Hidden;
            AddSale.Visibility = Visibility.Hidden;
            UpdatePriceProduct.Visibility = Visibility.Hidden;
            UpdateUnitsProduct.Visibility = Visibility.Hidden;
            UpdatLocationProduct.Visibility = Visibility.Hidden;
            UpdateSale.Visibility = Visibility.Hidden;
            DeleteSale.Visibility = Visibility.Hidden;

        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            UpdatePriceProduct.Visibility = Visibility.Visible;
            AddSale.Visibility = Visibility.Hidden;
            DeleteProduct.Visibility = Visibility.Hidden;
            UpdatLocationProduct.Visibility = Visibility.Hidden;
            UpdateUnitsProduct.Visibility = Visibility.Hidden;
            UpdateSale.Visibility = Visibility.Hidden;
            AddProduct.Visibility = Visibility.Hidden;
            DeleteSale.Visibility = Visibility.Hidden;
        }


        private void Label_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            UpdatLocationProduct.Visibility = Visibility.Visible;
            AddSale.Visibility = Visibility.Hidden;
            DeleteProduct.Visibility = Visibility.Hidden;
            UpdatePriceProduct.Visibility = Visibility.Hidden;
            UpdateUnitsProduct.Visibility = Visibility.Hidden;
            AddProduct.Visibility = Visibility.Hidden;
            UpdateSale.Visibility = Visibility.Hidden;
            DeleteSale.Visibility = Visibility.Hidden;
        }

      

        private void Label_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            List<SupperWazeBL.Platoon> list = funBL.GetPlatoonTable();
            foreach (SupperWazeBL.Platoon item in list)
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = item.PlatoonName;
                platoonListD.Items.Add(newItem);
            }
            DeleteProduct.Visibility = Visibility.Visible;
            AddSale.Visibility = Visibility.Hidden;
            UpdatePriceProduct.Visibility = Visibility.Hidden;
            UpdateUnitsProduct.Visibility = Visibility.Hidden;
            UpdatLocationProduct.Visibility = Visibility.Hidden;
            AddProduct.Visibility = Visibility.Hidden;
            UpdateSale.Visibility = Visibility.Hidden;
            DeleteSale.Visibility = Visibility.Hidden;

        }
        private void Label_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            AddSale.Visibility = Visibility.Visible;
            UpdateUnitsProduct.Visibility = Visibility.Hidden;
            DeleteProduct.Visibility = Visibility.Hidden;
            AddProduct.Visibility = Visibility.Hidden;
            UpdatePriceProduct.Visibility = Visibility.Hidden;
            UpdatLocationProduct.Visibility = Visibility.Hidden;
            UpdateSale.Visibility = Visibility.Hidden;
            DeleteSale.Visibility = Visibility.Hidden;
        }

        private void Label_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            List<SupperWazeBL.Platoon> list = funBL.GetPlatoonTable();
            foreach (SupperWazeBL.Platoon item in list)
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = item.PlatoonName;
                platoonListU.Items.Add(newItem);
            }
            UpdateUnitsProduct.Visibility = Visibility.Visible;
            AddSale.Visibility = Visibility.Hidden;
            DeleteProduct.Visibility = Visibility.Hidden;
            UpdatePriceProduct.Visibility = Visibility.Hidden;
            UpdatLocationProduct.Visibility = Visibility.Hidden;
            AddProduct.Visibility = Visibility.Hidden;
            UpdateSale.Visibility = Visibility.Hidden;
            DeleteSale.Visibility = Visibility.Hidden;
        }
        private void Label_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            UpdateSale.Visibility = Visibility.Visible;
            UpdateUnitsProduct.Visibility = Visibility.Hidden;
            AddProduct.Visibility = Visibility.Hidden;
            AddSale.Visibility = Visibility.Hidden;
            DeleteProduct.Visibility = Visibility.Hidden;
            UpdatePriceProduct.Visibility = Visibility.Hidden;
            UpdatLocationProduct.Visibility = Visibility.Hidden;
            DeleteSale.Visibility = Visibility.Hidden;
        }
        private void Label_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            List<SupperWazeBL.Platoon> list = funBL.GetPlatoonTable();
            foreach (SupperWazeBL.Platoon item in list)
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = item.PlatoonName;
                platoonListDS.Items.Add(newItem);
            }
            
            DeleteSale.Visibility = Visibility.Visible;
            UpdateSale.Visibility = Visibility.Hidden;
            UpdateUnitsProduct.Visibility = Visibility.Hidden;
            AddProduct.Visibility = Visibility.Hidden;
            AddSale.Visibility = Visibility.Hidden;
            DeleteProduct.Visibility = Visibility.Hidden;
            UpdatePriceProduct.Visibility = Visibility.Hidden;
            UpdatLocationProduct.Visibility = Visibility.Hidden;
        }


        // הוספת מוצר
        private void okBTN_newProduct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            double price = 0; int c = 0; ;
            try { price = Convert.ToDouble(ProductPrice.Text); }
            catch { ProductPrice.Text = ""; }
            try { c = Convert.ToInt32(ProductUnitStock.Text); }
            catch { ProductUnitStock.Text = ""; }
            //int platoonCode = (platoonList.SelectedItem as SupperWazeBL.Platoon).PlatoonCode;
            int platoonCode= Convert.ToInt32(funBL.GetPlatoonCodeByName(platoonList.SelectionBoxItem.ToString()));

            if (ProductPrice.Text != "" && ProductName.Text != "" && ProductName.Text != "" && ProductUnitStock.Text != "" && ProductCapacity.Text != "")
            {
                funBL.AddProduct(ProductName.Text, "", "", "", price, "", ProductCompany.Text, Convert.ToInt32(ProductUnitStock.Text), ProductCapacity.Text,platoonCode);
                ChooseLocation location = new ChooseLocation(ProductName.Text);
                location.Show();
            }
            else
            {
                MessageBox.Show("מלא את כל הפרטים");
            }
        }

        private void okBTN_updateLocationProduct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int code = funBL.GetProductCodeByProductName(ProductNameL.Text);
            if (code == -1)
                MessageBox.Show("מוצר לא נמצא");
            else
            {
                ChooseLocation lo = new ChooseLocation(ProductNameL.Text);
                lo.Show();
            }
                  
        }
        private void okBTN_updateProduct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //עדכון מוצר    
            
            string ProductName = ProductNameU.Text.ToString();
            int ProductCode = funBL.GetProductCodeByProductNameForUpdate(ProductName);
            double Price = Convert.ToDouble(ProductPriceU.Text);
            funBL.UpdatePriceProduct(ProductCode, Price);
            MessageBox.Show("מחיר המוצר עודכן בהצלחה");
            /*string nameProduct = ProductListD.SelectedValue.ToString();
            nameProduct = nameProduct.Substring(nameProduct.IndexOf(":") + 2);
            funBL.DeleteProduct(nameProduct);
            MessageBox.Show("מוצר הוסר בהצלחה");*/

        }

     
  private void okBTN_DeleteProduct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //מחיקת מוצר
            string nameProduct= ProductListD.SelectedValue.ToString();
            nameProduct = nameProduct.Substring(nameProduct.IndexOf(":") + 2);
            funBL.DeleteProduct(nameProduct);
            MessageBox.Show("מוצר הוסר בהצלחה");

        }
        private void platoonListD_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductListD.Items.Clear();
            ProductListD.IsEnabled = true;
            string i = platoonListD.SelectedValue.ToString();
            i=i.Substring(i.IndexOf(":")+2);
            List<SupperWazeENTITIES.Product> list = funBL.GetSProductPlatoon(i);
            foreach (SupperWazeENTITIES.Product item in list)
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = item.ProductDescription;
                ProductListD.Items.Add(newItem);
            }
        }

        private void okBTN_UpdateUnitsProduct_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int unit = Convert.ToInt32(ProductUnitStockUpdate.Text);
            string nameProduct = ProductListU.SelectedValue.ToString();
            nameProduct = nameProduct.Substring(nameProduct.IndexOf(":") + 2);
        }

        private void platoonListU_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductListU.Items.Clear();
            ProductListU.IsEnabled = true;
            string i = platoonListU.SelectedValue.ToString();
            i = i.Substring(i.IndexOf(":") + 2);
            List<SupperWazeENTITIES.Product> list = funBL.GetSProductPlatoon(i);
            foreach (SupperWazeENTITIES.Product item in list)
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = item.ProductDescription;
                ProductListU.Items.Add(newItem);
            }
        }

        private void okBTN_newSale_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int code = funBL.GetProductCodeByProductName(ProductNameSale.Text);
            if (code == -1)
                MessageBox.Show("אין מוצר כזה");
            else
            {
                //שילחה לפונקציה שתקבל את הפרמטרים:
      //          code
      //MinimumNumberOfUnitsToBuy.Text
      //MinimumPurshasePricePerOffer.Text
      //SalePriceForUnit.Text
      //SalePriceForAmount.Text
    }
        }

        private void okBTN_updateSale_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int code = funBL.GetProductCodeByProductName(ProductNameSaleU.Text);
            if (code == -1)
                MessageBox.Show("אין מוצר כזה");
            else
            {
                //שילחה לפונקציה שתקבל את הפרמטרים:
                //          code
                //MinimumNumberOfUnitsToBuyU.Text
                //MinimumPurshasePricePerOfferU.Text
                //SalePriceForUnitU.Text
                //SalePriceForAmountU.Text
            }
        }

        private void okBTN_DeleteSale_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //לשלוח לפונקצית מחיקת מבצע

            string nameProduct = ProductListDS.SelectedValue.ToString();
            nameProduct = nameProduct.Substring(nameProduct.IndexOf(":") + 2);
            int code = funBL.GetProductCodeByProductName(nameProduct);

            //הפרמטרים:
            //code
        }

        private void platoonListDS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             ProductListDS.Items.Clear();
            ProductListDS.IsEnabled = true;
            string i = platoonListDS.SelectedValue.ToString();
            i = i.Substring(i.IndexOf(":") + 2);
            List<SupperWazeENTITIES.Product> list = funBL.GetSProductPlatoon(i);
            foreach (SupperWazeENTITIES.Product item in list)
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = item.ProductDescription;
                ProductListDS.Items.Add(newItem);
            }
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
           (sender as Label).Foreground = Brushes.Red;
        }

        private void lbl1_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Label).Foreground = new SolidColorBrush(Color.FromRgb(237, 125, 49));
        }
    }
}
