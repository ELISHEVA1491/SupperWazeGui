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
using SupperWazeENTITIES;
using SupperWazeBL;
using System.Data;
using System.ComponentModel;

namespace SupperWazeGUI.Forms
{
    /// <summary>
    /// Interaction logic for Display.xaml
    /// </summary>
    public partial class Display : Window
    {
        public List<Product> list;
        public Display()
        {
            InitializeComponent();
            //DataTable products = new DataTable();
            //products.Columns.Add("ProductId");
            //FunctionBL functionBL = new FunctionBL();
            //productsList = functionBL.GetSProductsTable();

            //foreach (var Product in productsList)
            //{
            //    DataRow row;               
            //}

            List<Product> productsList;
            FunctionBL f = new FunctionBL();
            //productsList = f.GetSProductsTable();
            //Lvproducts.ItemsSource = productsList;
            //ListViewProd.ItemsSource = productsList;
                //ConvertListToDataTable(productsList);
            
        }

         public DataTable ConvertListToDataTable <T> (IList<T> Data)
        {
            PropertyDescriptorCollection p = TypeDescriptor.GetProperties(typeof(T));
            DataTable dt = new DataTable();
            foreach ( PropertyDescriptor prop in p)
            {
                dt.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach(T item in Data)
            {
                DataRow row = dt.NewRow();
                foreach(PropertyDescriptor prop in p)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;                  
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
        //DataTable dt = new DataTable();
        //_observableCollection = new ObservableCollection<Student>();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        Student s = new Student();

        //        s.StudentID = (long)row["StudentID"];
        //        s.StudentFirstName = (string)row["StudentFirstName"];
        //        s.StudentLastName = (string)row["StudentLastName"];
        //        s.DateOfBirth = (DateTime)row["DateOfBirth"];
        //        s.FatherName = (string)row["FatherName"];
        //        s.MotherName = (string)row["MotherName"];
        //        _observableCollection.Add(s);
        //    }
        //    Lvstudents.ItemsSource = _observableCollection;
    }
}


       



