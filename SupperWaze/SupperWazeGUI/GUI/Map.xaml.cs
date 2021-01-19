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
using SupperWazeBL;
using SupperWazeGUI;

namespace SupperWazeGUI.GUI
{
    /// <summary>
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : UserControl
    {
        FunctionBL funBL = new FunctionBL();
        List<string> dr;
        List<SupperWazeBL.ProductListInOrder> ShoppingListInOrderMap = new List<ProductListInOrder>();
        List<string> pointsMap = new List<string>();
        int num,CurrentProductId = 0;
        int i = 0, j = 0;
        public Map(List<SupperWazeBL.ProductListInOrder> ShoppingListInOrder, List<string> points)
        {
            InitializeComponent();
            //dr = funBL.DisplayRoute();
            ShoppingListInOrderMap = ShoppingListInOrder;
            pointsMap = points;
            num = ShoppingListInOrderMap.Count();
        }
        
        public void HightOrangeLine(string point1, string point2)
        {
            string ImageName = "";
            bool IfHeight = false;
            string[] point1Int = point1.Split('_');
            string[] point2Int = point2.Split('_');
            if (Convert.ToInt32(point1Int[0]) == Convert.ToInt32(point2Int[0])) //קו לאורך
            {
                IfHeight = true;
                if (Convert.ToInt32(point1Int[1]) < Convert.ToInt32(point2Int[1]))
                {
                    ImageName = "l_" + point1 + "_" + point2;
                }
                else
                {
                    ImageName = "l_" + point2 + "_" + point1;
                }
            }
            else
            {
                if (Convert.ToInt32(point1Int[0]) < Convert.ToInt32(point2Int[0]))
                {
                    ImageName = "l_" + point1 + "_" + point2;
                }
                else
                {
                    ImageName = "l_" + point2 + "_" + point1;
                }

            }
            
            
            
            Image ImageLine = FindName(ImageName) as Image;

            if(ImageLine != null)
            {
                if(IfHeight == true)
                    ImageLine.Source = new BitmapImage(new Uri(@"..\..\Images\lineO.png", UriKind.Relative));
                else
                    ImageLine.Source = new BitmapImage(new Uri(@"..\..\Images\LineOW.png", UriKind.Relative));
                
            }
                
        }

        public void WidthOrangeLine(string point1, string point2)
        {
            string ImageName = "l_" + point1 + "_" + point2;
            //ImageName.Source = new BitmapImage(new Uri(@"..\..\Image\lineOW.png", UriKind.Relative));
        }
        public void PinkLine(string point1, string point2)
        {
            string ImageName = "";
            bool IfHeight = false;
            string[] point1Int = point1.Split('_');
            string[] point2Int = point2.Split('_');
            if (Convert.ToInt32(point1Int[0]) == Convert.ToInt32(point2Int[0])) //קו לאורך
            {
                IfHeight = true;
                if (Convert.ToInt32(point1Int[1]) < Convert.ToInt32(point2Int[1]))
                {
                    ImageName = "l_" + point1 + "_" + point2;
                }
                else
                {
                    ImageName = "l_" + point2 + "_" + point1;
                }
            }
            else
            {
                if (Convert.ToInt32(point1Int[0]) < Convert.ToInt32(point2Int[0]))
                {
                    ImageName = "l_" + point1 + "_" + point2;
                }
                else
                {
                    ImageName = "l_" + point2 + "_" + point1;
                }

            }



            Image ImageLine = FindName(ImageName) as Image;

            if (ImageLine != null)
            {
                if (IfHeight == true)
                    ImageLine.Source = new BitmapImage(new Uri(@"..\..\Images\LineP.png", UriKind.Relative));
                else
                    ImageLine.Source = new BitmapImage(new Uri(@"..\..\Images\LinePW.png", UriKind.Relative));

            }
        }

               public void WidthPinkLine(string point1, string point2)
        {
            string ImageName = "l_" + point1 + "_" + point2;
            //ImageName.Source = new BitmapImage(new Uri(@"..\..\Image\linePW.png", UriKind.Relative));
        }
        public void HigthGrayLine(string point1, string point2)
        {
            string ImageName = "l_" + point1 + "_" + point2;
            //ImageName.Source = new BitmapImage(new Uri(@"..\..\Image\lineGH.png", UriKind.Relative));
        }
        public void WidthGrayLine(string point1, string point2)
        {
            string ImageName = "l_" + point1 + "_" + point2;
            //ImageName.Source = new BitmapImage(new Uri(@"..\..\Image\lineGW.png", UriKind.Relative));
        }
        //ניווט למוצר הבא
        private void nextProductBTN_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SupperWazeENTITIES.Product NextProduct = new SupperWazeENTITIES.Product();
            //NextProduct = ShoppingListInOrderMap[CurrentProductId]; 
                
                    
            if(i == num -1) //אם הוא במוצר האחרון
            {
                MessageBox.Show("זהו, סיימנו...");
                return;
            }
            else
            {
                List<string> pointProd1 = new List<String>();
                List<string> pointProd2 = new List<String>();
                pointProd1.Add(ShoppingListInOrderMap[i].DProduct.ProductLocationX.ToString());
                pointProd1.Add(ShoppingListInOrderMap[i].DProduct.ProductLocationY.ToString());
                pointProd2.Add(ShoppingListInOrderMap[i+1].DProduct.ProductLocationX.ToString());
                pointProd2.Add(ShoppingListInOrderMap[i+1].DProduct.ProductLocationY.ToString());
                string[] listPoints = new string[2];
                //for (int j = 0; j <
                bool IfFound = false;
                while (IfFound == false && j<pointsMap.Count - 1)
                {
                    if (pointsMap[j].Replace(" ",String.Empty) != (pointProd2[0] + "_" + pointProd2[1]).Replace(" ", String.Empty))
                    {
                        listPoints[0] = pointsMap[j];
                        listPoints[1] = pointsMap[j + 1];
                        PinkLine(listPoints[0], listPoints[1]);
                        j++;
                    }
                    else
                        IfFound = true;
                }
                //PinkLine(pointProd1[0] , pointProd2[0]);
                //IfFound = true;
                i = i + 1;
            }
                                 
           LBLProducts.Content= "לקחת" + i + "מוצרים" + "מתוך" + num + "שברשימה"; 
        }
    }
}
