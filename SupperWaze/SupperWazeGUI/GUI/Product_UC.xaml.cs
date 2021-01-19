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
    /// Interaction logic for Product_UC.xaml
    /// </summary>
    public partial class Product_UC : UserControl
    {

        #region Properties

        public int Code
        {
            get { return (int)GetValue(codeProperty); }
            set { SetValue(codeProperty, value); }
        }
        public static readonly DependencyProperty codeProperty =
            DependencyProperty.Register("Code", typeof(int), typeof(Product_UC), new PropertyMetadata(0));


        public String Description//שם המוצר
        {
            get { return (String)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(String), typeof(Product_UC), new PropertyMetadata(String.Empty));


        public double Price//מחיר
        {
            get { return (double)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(double), typeof(Product_UC), new PropertyMetadata(0.0));

        public int Quntity//כמות
        {
            get { return (int)GetValue(QuntityProperty); }
            set { SetValue(QuntityProperty, value); }
        }
        public static readonly DependencyProperty QuntityProperty =
            DependencyProperty.Register("Quntity", typeof(int), typeof(Product_UC), new PropertyMetadata(0));

        public String ImageSource
        {
            get { return (String)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(String), typeof(Product_UC), new PropertyMetadata(String.Empty));

        #endregion

        public Product_UC() {  InitializeComponent();}
        public Product_UC(int code,string name,double price,string platoon):this()//מקבל את שם המוצר, המחלקה שלו, והמחיר
        {
           
            this.Code = code;
            this.Price = price;
            this.Description = name;
            this.ImageSource= @"..\Images\"+platoon +"\\" + Description + ".png";
            quntityLBL.DataContext = Quntity;
            priceLBL.DataContext = Price;
            desLBL.DataContext = Description;
        }

        private void add_to_cart_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Quntity==0)
            {
                MessageBox.Show("לא נבחרה כמות", "", MessageBoxButton.OK, MessageBoxImage.None);
            }
            else
            {
                Forms.TheSoppingMenu.listToBuy.Add(new SupperWazeENTITIES.LastShopping() { ProductAmount = Quntity, ProductCode = Code });
                MessageBox.Show("מוצר הוסף לעגלה");
               
            }
        }

        private void plus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Quntity++;
        }

        private void minus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.Quntity >0)
                this.Quntity--;
        }
    }
}
