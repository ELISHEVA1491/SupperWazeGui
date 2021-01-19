using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupperWazeDAL;
using SupperWazeENTITIES;

namespace SupperWazeBL
{
    public class FunctionBL
    {
        private static object math;
        private object query;

        public List<Product> GetSProductsTable()
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select * from Products");
            List<Product> products = new List<Product>();
            foreach (DataRow row in dataTable.Rows)
            {
                Product p = new Product();
                p.ProductCode = checked((int)row["ProductCode"]);
                p.ProductDescription = row["ProductDescription"].ToString();
                p.ProductLocationX = row["ProductLocationX"].ToString();
                p.ProductLocationY = row["ProductLocationY"].ToString();
                p.ProductLocationSide = row["ProductLocationSide"].ToString();
                p.ProductPrice = checked((double)row["ProductPrice"]);
                try
                {
                    p.SaleCode = checked((string)row["SaleCode"]);
                }
                catch
                {
                    p.SaleCode = "";
                }
                p.ProductCompany = checked((string)row["ProductCompany"]);
                p.UnitsInStock = checked((int)row["UnitsInStock"]);
                p.ProductCapacity = checked((string)row["ProductCapacity"]);
                p.PlatoonCode = checked((int)row["PlatoonCode"]);
                products.Add(p);
            }

            return products;
        }

        public Product GetProductDetailsByCode(int ProductCode)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select * from Products where ProductCode =" + ProductCode);
            Product p = new Product();
            foreach (DataRow row in dataTable.Rows)
            {
                p.ProductCode = checked((int)row["ProductCode"]);
                p.ProductDescription = row["ProductDescription"].ToString();
                p.ProductLocationX = row["ProductLocationX"].ToString();
                p.ProductLocationY = row["ProductLocationY"].ToString();
                p.ProductLocationSide = row["ProductLocationSide"].ToString();
                p.ProductPrice = checked((double)row["ProductPrice"]);
                try
                {
                    p.SaleCode = checked((string)row["SaleCode"]);
                }
                catch
                {
                    p.SaleCode = "";
                }
                p.ProductCompany = checked((string)row["ProductCompany"]);
                p.UnitsInStock = checked((int)row["UnitsInStock"]);
                p.ProductCapacity = checked((string)row["ProductCapacity"]);
                p.PlatoonCode = checked((int)row["PlatoonCode"]);
            }
            return p;
        }

        public List<Product> GetSProductPlatoon(string PlatoonName)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select * from Products where PlatoonCode=(select PlatoonCode from Platoon where PlatoonName='" + PlatoonName + "')");
            List<Product> products = new List<Product>();
            foreach (DataRow row in dataTable.Rows)
            {
                Product p = new Product();
                p.ProductCode = checked((int)row["ProductCode"]);
                p.ProductDescription = row["ProductDescription"].ToString();
                p.ProductLocationX = row["ProductLocationX"].ToString();
                p.ProductLocationY = row["ProductLocationY"].ToString();
                p.ProductLocationSide = row["ProductLocationSide"].ToString();
                p.ProductPrice = checked((double)row["ProductPrice"]);
                try
                {
                    p.SaleCode = checked((string)row["SaleCode"]);
                }
                catch
                {
                    p.SaleCode = "";
                }
                p.ProductCompany = checked((string)row["ProductCompany"]);
                p.UnitsInStock = checked((int)row["UnitsInStock"]);
                p.ProductCapacity = checked((string)row["ProductCapacity"]);
                p.PlatoonCode = checked((int)row["PlatoonCode"]);
                products.Add(p);
            }

            return products;
        }

        public List<Platoon> GetPlatoonTable()
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select * from Platoon");

            List<Platoon> Platoon = new List<Platoon>();
            foreach (DataRow row in dataTable.Rows)
            {
                Platoon p = new Platoon();
                p.PlatoonCode = checked((int)row["PlatoonCode"]);
                p.PlatoonName = row["PlatoonName"].ToString();
                p.PlatoonLocation = row["PlatoonLocation"].ToString();
                Platoon.Add(p);
            }

            return Platoon;
        }
        public List<Clients> GetSClientsTable()
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select * from Clients");

            List<Clients> clients = new List<Clients>();
            foreach (DataRow row in dataTable.Rows)
            {
                Clients c = new Clients();
                c.ClientCode = checked((int)row["ClientCode"]);
                c.ClientName = row["ClientName"].ToString();
                c.ClientAdress = row["ClientAdress"].ToString();
                c.ClientPhone = row["ClientPhone"].ToString();
                c.LastShoppingCode = row["LastShoppingCode"].ToString();
                clients.Add(c);
            }

            return clients;
        }
        public List<Transition> GetTransitionable()
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select * from Transition");

            List<Transition> transition = new List<Transition>();
            foreach (DataRow row in dataTable.Rows)
            {
                Transition t = new Transition();
                t.TransitionX = row["TransitionX"].ToString();
                t.TransitionY = row["TransitionY"].ToString();
                t.TransitionMain = checked((bool)row["TransitioMain"]);
                transition.Add(t);
            }

            return transition;
        }

        public List<LastShopping> LastShoppingTable
        {
            get
            {
                RunQueriesOnDB connect = new RunQueriesOnDB();
                DataTable dataTable = connect.RunAnySqlQueryOnDB("select * from LastShopping");

                List<LastShopping> lastShopping = new List<LastShopping>();
                foreach (DataRow row in dataTable.Rows)
                {
                    LastShopping l = new LastShopping();
                    l.LastShoppingCode = row["LastShoppingCode"].ToString();
                    l.ClientCode = checked((int)row["ClientCode"]);
                    l.ProductCode = checked((int)row["ProductCode"]);
                    l.ProductAmount = checked((int)row["ProductAmount"]);
                    lastShopping.Add(l);
                }

                return lastShopping;
            }
        }

        public List<Sales> GetSalesTable()
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select * from Sales");

            List<Sales> sales = new List<Sales>();
            foreach (DataRow row in dataTable.Rows)
            {
                Sales s = new Sales();
                s.SaleCode = checked((int)row["SaleCode"]);
                s.ProductCode = checked((int)row["ProductCode"]);
                s.MinimumNumberOfUnitsToBuy = checked((int)row["MinimumNumberOfUnitsToBuy"]);
                s.MinimumPurshasePricePerOffer = checked((int)row["MinimumPurshasePricePerOffer"]);
                s.SalePriceForUnit = row["SalePriceForUnit"].ToString();
                s.SalePriceForAmount = row["SalePriceForAmount"].ToString();
                sales.Add(s);
            }

            return sales;
        }
        public List<LastShopping> GetLastShoppingClientsTable(int ClientCode)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select * from LastShopping where clientCode=clientCode");

            List<LastShopping> lastShopping = new List<LastShopping>();
            foreach (DataRow row in dataTable.Rows)
            {
                LastShopping l = new LastShopping();
                l.LastShoppingCode = row["LastShoppingCode"].ToString();
                l.ClientCode = checked((int)row["ClientCode"]);
                l.ProductCode = checked((int)row["ProductCode"]);
                l.ProductAmount = checked((int)row["ProductAmount"]);
                lastShopping.Add(l);
            }

            return lastShopping;
        }
        // פונקציה שמקבלת קוד מוצר ומחזירה את שמו
        public String GetProductNameByProductCode(int ProductCode)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select ProductDescription  from Products where ProductCode =" + ProductCode);
            string name = dataTable.Rows[0]["ProductDescription"].ToString();
            return name;
        }

        public String GetPlatoonCodeByName(string PlatoonName)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select PlatoonCode  from Platoon where PlatoonName =N'" + PlatoonName + "'");
            string name = dataTable.Rows[0]["PlatoonCode"].ToString();
            return name;
        }

        // פונקציה שמקבלת קוד מוצר ומחזירה את המחיר
        public double GetProductPriceByProductCode(int ProductCode)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            string query = string.Format("select ProductPrice  from Products where ProductCode = " + ProductCode);
            DataTable dataTable = connect.RunAnySqlQueryOnDB(query);
            double price = checked((double)dataTable.Rows[0]["ProductPrice"]);
            return price;
        }
        //פונקציה שמקבלת טלפון לקוח ומחזירה את הקוד לקוח
        public int GetClientCodeByClientPhone(string clientPhone)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select ClientCode from clients where ClientPhone = '" + clientPhone + "'");
            if (dataTable.Rows.Count == 0)//אם אין לקוח כזה
                return -1;
            int code = checked((int)dataTable.Rows[0]["clientCode"]);
            return code;
        }
        //פונקציה שמוסיפה לקוח חדש ומחזירה את הקוד שלו ומזמנת את הפונקצייה הקודמת

        public int AddClientAndGetClientCode(string clientName, string clientAdress, string clientPhone)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("insert into [clients](ClientName,ClientAdress,ClientPhone) values('" + clientName + "','" + clientAdress + "','" + clientPhone + "')");
            int code = GetClientCodeByClientPhone(clientPhone);
            return code;
        }
        //פונקציה שמקבלת שם מוצר ומחזירה קוד  
        public int GetProductCodeByProductName(string ProductName)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            string query = string.Format("select ProductCode from Products where ProductDescription like N'" + ProductName + "'");
            DataTable dataTable = connect.RunAnySqlQueryOnDB(query);
            if (dataTable.Rows.Count == 0)//אם אין מוצר כזה
                return -1;
            int Code = checked((int)dataTable.Rows[0]["ProductCode"]);
            return Code;
        }

        public int GetProductCodeByProductNameForUpdate(string ProductName)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            string query = string.Format("select ProductCode from Products where ProductDescription like N'%" + ProductName + "%'");
            DataTable dataTable = connect.RunAnySqlQueryOnDB(query);
            if (dataTable.Rows.Count == 0)//אם אין מוצר כזה
                return -1;
            int Code = checked((int)dataTable.Rows[0]["ProductCode"]);
            return Code;
        } 
        //הוספת מוצר
        public void AddProduct(string ProductDescription, string ProductLocationX, string ProductLocationY, string ProductLocationSide, double ProductPrice, string SaleCode, string ProductCompany, int UnitsInStock, string ProductCapacity, int PlatoonCode)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("insert into [Products](ProductDescription, ProductLocationX,ProductLocationY, ProductLocationSide, ProductPrice, SaleCode,ProductCompany,UnitsInStock,ProductCapacity,PlatoonCode) values(N'" + ProductDescription + "','" + ProductLocationX + "','" + ProductLocationY + "','" + ProductLocationSide + "','" + ProductPrice + "','" + SaleCode + "','" + ProductCompany + "','" + UnitsInStock + "','" + ProductCapacity + "','"+PlatoonCode+"')");
        }
        //מחיקת מוצר
        public void DeleteProduct(string ProductDescription)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("delete from [Products] where ProductDescription = N'" + ProductDescription + "'");
        }
        //עדכון מחיר מוצר
        public void UpdatePriceProduct(int ProductCode, double ProductPrice)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            //            DataTable dataTable = connect.RunAnySqlQueryOnDB("(UPDATE [Products] set ProductPrice= ProductPrice) where ProductCode = ProductCode  values('" + ProductPrice + "')");
            DataTable dataTable = connect.RunAnySqlQueryOnDB("UPDATE [Products] set ProductPrice= " + ProductPrice + " where ProductCode = " + ProductCode);
        }
        //עדכון מלאי
        public void UpdateUnitsInStockProduct(int ProductCode, int UnitsInStock)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("(UPDATE [Products] set UnitsInStock= UnitsInStock) where ProductCode = ProductCode  values('" + UnitsInStock + "')");
        }
        //עדכון מיקום מוצר
        public void UpdateProductLocation(int ProductCode, string ProductLocationX, string ProductLocationY, string ProductLocationSide)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("(UPDATE [Products] set ProductLocationX=ProductLocationX,ProductLocationY=ProductLocationY,ProductLocationSide=ProductLocationSide) where ProductCode = ProductCode  values('" + ProductLocationX + "','" + ProductLocationY + "','" + ProductLocationSide + "')");
        }
        //הוספת מבצע 
        public void AddSalePrice(int SaleCode, int ProductCode, int MinimumNumberOfUnitsToBuy, int MinimumPurshasePricePerOffer, int SalePriceForUnit, int SalePriceForAmount)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("insert into [Sales](SaleCode, ProductCode,MinimumNumberOfUnitsToBuy, MinimumPurshasePricePerOffer, SalePriceForUnit, SalePriceForAmount) values('" + SaleCode + "','" + ProductCode + "','" + MinimumNumberOfUnitsToBuy + "','" + MinimumPurshasePricePerOffer + "','" + SalePriceForUnit + "','" + SaleCode + "','" + SalePriceForAmount + "')");
        }
        //עדכון מבצע
        public void UpdateSalePrice(int SaleCode, int ProductCode, int MinimumNumberOfUnitsToBuy, int MinimumPurshasePricePerOffer, int SalePriceForUnit, int SalePriceForAmount)// לא התייחסתי לפרודקט קוד האם זה בסדר?
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("(UPDATE [Sales] set MinimumNumberOfUnitsToBuy=MinimumNumberOfUnitsToBuy,MinimumPurshasePricePerOffer=MinimumPurshasePricePerOffer, SalePriceForUnit=SalePriceForUnit,SalePriceForAmount=SalePriceForAmount) where SaleCode=SaleCode  values('" + SaleCode + "','" + ProductCode + "','" + MinimumNumberOfUnitsToBuy + "','" + MinimumPurshasePricePerOffer + "','" + SalePriceForUnit + "','" + SalePriceForAmount + "')");
        }
        //מחיקת מבצע
        public void DeleteSalePrice(int SaleCode, int ProductCode, int MinimumNumberOfUnitsToBuy, int MinimumPurshasePricePerOffer, int SalePriceForUnit, int SalePriceForAmount)// לא התייחסתי לפרודקט קוד האם זה בסדר?
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("delete from [Sales](SaleCode, ProductCode,MinimumNumberOfUnitsToBuy, MinimumPurshasePricePerOffer, SalePriceForUnit, SalePriceForAmount) values('" + SaleCode + "','" + ProductCode + "','" + MinimumNumberOfUnitsToBuy + "','" + MinimumPurshasePricePerOffer + "','" + SalePriceForUnit + "','" + SaleCode + "','" + SalePriceForAmount + "')");
        }
        // פונקצייה שמקבלת ערכי איקס וואי ומחזירה האם הם מעבר ראשי
        public bool CheckingTransitionMain(string TransitionX, string TransitionY)
        {
            bool b = true;
            RunQueriesOnDB connect = new RunQueriesOnDB();
            b = Convert.ToBoolean(connect.RunSqlQueryAndReturnString(String.Format("select TransitionMain from Transition where TransitionX={0} AND TransitionY={1} ", TransitionX, TransitionY)));
            //b = Convert.ToBoolean(connect.RunAnySqlQueryOnDB(String.Format("select TransitionMain from Transition where TransitionX={0} AND TransitionY={1} ", TransitionX, TransitionY))); 
            //b = Convert.ToBoolean(String.Format("select TransitionMain from Transition where TransitionX={0} AND TransitionY={1} ",TransitionX ,TransitionY));
            if (b)
                return true;
            return false;
        }
        //פונקציה שמקבלת רשימת מוצרים ומחזירה רשימת מוצרים לפי סדר הקנייה פלוס נקודת מעבר ראשי לכל מוצר ברשימה
        public List<ProductListInOrder> ShoppingListInOrder(List<Product> list1)
        {
            bool d = true;
            bool m = false;            
                            //צריך להוסיף תנאי עצירה אם הוא העלה את ווי מספר פעמים מסויים ולא הגיע למעבר ראשי-
            List<ProductListInOrder> pl1 = new List<ProductListInOrder>();
            int min = 1000, code = 0, x, y, sum, xt = 0, yt = 0;
            List<Product> l1 = list1;//רשימה אחת זהו המוצר העכשווי ורשימה 2 זהו מוצר המקור

            //Product CurrentProduct = l1[0];
            Product CurrentProduct = new Product(); //לדאוג להכניס את המוצר שהכי קרוב לכניסה לרשימה במקום הראשון
            CurrentProduct.ProductCode = -1;
            CurrentProduct.ProductLocationX = "0";
            CurrentProduct.ProductLocationY = "0";

            // עובר על כל המוצרים שברשימה
            while (l1.Count != 1)
            {
                for (int i = 0; i < l1.Count; i++)
                {
                    if (l1[i].ProductCode != CurrentProduct.ProductCode)// שלא ישווה את הדרך מעצמו לעצמו
                    {
                        if (CurrentProduct.ProductLocationX == l1[i].ProductLocationX)//כשהאיקסים שווים
                        {
                            //אם המסלול ביניהם קטן מערך המסלול השמור במין
                            if (Math.Abs(Convert.ToInt32(CurrentProduct.ProductLocationY) - Convert.ToInt32(l1[i].ProductLocationY)) < min)
                            {
                                min = Math.Abs(Convert.ToInt32(CurrentProduct.ProductLocationY) - Convert.ToInt32(l1[i].ProductLocationY));
                                code = i;
                                xt = Convert.ToInt32(l1[i].ProductLocationX);
                                yt = Convert.ToInt32(l1[i].ProductLocationY);
                                //צריך להכניס כאן ערך כלשהוא לנקודת מעבר, למרות שזה לא משמעותי למתיחת קווים
                                // כי אחרת הוא ייפול בגלל שלוא יהיה לו ערך בנקודת מעבר!!
                            }
                        }
                        else //אם 2 המוצרים על ציר איקס וואי שונה אז צריך לחשב מסלול לפי הנוסחא
                        {
                            //חישוב מסלול מלמטה
                            x = Convert.ToInt32(CurrentProduct.ProductLocationX);
                            y = Convert.ToInt32(CurrentProduct.ProductLocationY);
                            //הולכים למעבר ראשי מלמטה
                            // שיבין שאין מעבר ראשי
                            //אולי להתייחס כמו מטריצה
                            m = false;
                            while (m != true)
                            {
                                y = y == 0? 0 : y - 1;
                                //y = y - 1;
                                m = CheckingTransitionMain(x.ToString(), y.ToString());
                            }
                            //אחרי שיוצא מהלולאה, הוא נמצא במעבר ראשי
                            sum = Math.Abs(Convert.ToInt32(CurrentProduct.ProductLocationX) - Convert.ToInt32(l1[i].ProductLocationX)) + (Math.Abs((y - Convert.ToInt32(CurrentProduct.ProductLocationY))) + Math.Abs((y - Convert.ToInt32(l1[i].ProductLocationY))));
                            if (sum < min)//אם אורך המסלול קטן מאורך המסולול השמור במין 
                            {
                                min = sum;
                                code = i;
                                xt = x;
                                yt = y;
                            }
                            //חישוב מסלול מלמעלה
                            m = false;
                            y = Convert.ToInt32(CurrentProduct.ProductLocationY);//Y מקור
                            while (m != true)// כל עוד לא הגעת לנקודת מעבר
                            {
                                y++;
                                m = CheckingTransitionMain(x.ToString(), y.ToString());
                            }
                            sum = Math.Abs(Convert.ToInt32(CurrentProduct.ProductLocationX) - Convert.ToInt32(l1[i].ProductLocationX)) + (Math.Abs((y - Convert.ToInt32(CurrentProduct.ProductLocationY))) + Math.Abs((y - Convert.ToInt32(l1[i].ProductLocationY))));
                            if (sum < min)
                            {
                                min = sum;
                                code = i;
                                xt = x;
                                yt = y;
                            }
                        }
                    }
                }// for סגירת

                // אחרי שיצאנו מהפור, יש בתוך מין את אורך המסלול הקצר ביותר ובתוך אי את אינדקס מוצר היעד

                //הכנסת מוצר המקור לתוך הרשימה השנייה והעברת ההפניה שהיתה עליו למוצר היעד
                //שמוצר היעד נהפך להיות מוצר המקור
               
                    ProductListInOrder pnew = new ProductListInOrder();
                    Product PreviousProduct = new Product();
                    pnew.DProduct = CurrentProduct;
                    pnew.DTransitionX = xt;
                    pnew.DTransitionY = yt;
                    pl1.Add(pnew);
                    PreviousProduct = CurrentProduct;
                    CurrentProduct = l1[code];
                    l1.Remove(PreviousProduct);
               
                min = 1000;
                code = 0;
                xt = 0;
                yt = 0;
                //CurrentProduct = l1[code];

            }// while (l1 != null)
                ProductListInOrder pLast = new ProductListInOrder();
                pLast.DProduct = l1[0];
                pLast.DTransitionX = Convert.ToInt32(l1[0].ProductLocationX);
                pLast.DTransitionY = Convert.ToInt32(l1[0].ProductLocationY);
                pl1.Add(pLast);
                return pl1;
        }

         // פונקציה המחזירה רשימה המכילה את כל נקודות המעבר למסלול הקנייה
         // הפונקציה נעזרת בפונקציה קלקוילשן
         public  List<String> DisplayRoute(List<ProductListInOrder> pl1)
          {
            List<string> allPoints = new List<string>();
            string CalculationResult = "";
              for (int i = 0; i < pl1.Count-1; i++)
              {
                if (pl1[i].DProduct.ProductLocationX == pl1[i + 1].DProduct.ProductLocationX)//2 המוצר על אתו ציר X
                {
                    CalculationResult = calculation(true, Convert.ToInt32(pl1[i].DProduct.ProductLocationX), Convert.ToInt32(pl1[i].DProduct.ProductLocationY), Convert.ToInt32(pl1[i + 1].DProduct.ProductLocationY));
                    string[] temp = CalculationResult.Split(',');
                    //מכניס לתוך המערך את כל נקודות המעבר במסלול ממוצר המקור למוצר היעד
                    for (int j = 0; j < temp.Length-1; j++)
                    {
                        allPoints.Add(temp[j]);
                    }
                }
                else // ציר X שונה
                {
                    //מכניס לתוך המערך את כל נקודות המעבר במסלול ממוצר המקור לנקודת המעבר
                    CalculationResult = calculation(true, Convert.ToInt32(pl1[i].DProduct.ProductLocationX), Convert.ToInt32(pl1[i].DProduct.ProductLocationY), Convert.ToInt32(pl1[i].DTransitionY));
                    CalculationResult = CalculationResult.Substring(0, CalculationResult.Length - 1);
                    string[] temp = CalculationResult.Split(',');
                    for (int j = 0; j < temp.Length-1; j++)
                    {
                        allPoints.Add(temp[j]);
                    }

                    //מכניס לתוך המערך את כל נקודות המעבר במסלול מנקודת המעבר ל-X יעד
                    CalculationResult = calculation(false, Convert.ToInt32(pl1[i].DTransitionY), Convert.ToInt32(pl1[i].DTransitionX), Convert.ToInt32(pl1[i + 1].DProduct.ProductLocationX));
                    CalculationResult = CalculationResult.Substring(0, CalculationResult.Length - 1);
                    temp = CalculationResult.Split(',');
                    for (int j = 0; j < temp.Length-1; j++)
                    {
                        allPoints.Add(temp[j]);
                    }

                    //מוצר היעד מכניס לתוך המערך את כל נקודות המעבר במסלול מנקודת המעבר ל
                    CalculationResult = calculation(true, Convert.ToInt32(pl1[i + 1].DProduct.ProductLocationX), Convert.ToInt32(pl1[i].DTransitionY), Convert.ToInt32(pl1[i + 1].DProduct.ProductLocationY));
                    CalculationResult = CalculationResult.Substring(0, CalculationResult.Length - 1);
                    temp = CalculationResult.Split(',');
                    for (int j = 0; j < temp.Length; j++)
                    {
                        allPoints.Add(temp[j]);
                    }
                }
            }
            return allPoints;
          }

      public static string calculation(bool isXaxis, int axis, int location, int destination)
{
  string point = "";
  int factor = destination < location ? -1 : 1;
  for (int i = location; i - factor != destination; i += factor)
  {
      point += isXaxis ? axis.ToString() +"_" + i.ToString() : i.ToString() + "_" + axis.ToString();
      point += ",";

  }
  return point;
}

        /*public List<string> GetProductItemByProductCode(string PCode)
        {
           
        }*/
        //פונקציה שמקבלת קוד מוצר ומחזירה מיקום איקס
        public string GetLocationXByProductCode(string PCode)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select ProduLocationX  from Products where ProductCode =" + PCode);
            string locationX = dataTable.Rows[0]["ProductDescription"].ToString();
            return locationX;
        }
        public string GetLocationYByProductCode(string PCode)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select ProduLocationY  from Products where ProductCode =" + PCode);
            string locationY = dataTable.Rows[0]["ProductDescription"].ToString();
            return locationY;
        }
        public string GetLocationSideByProductCode(string PCode)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select ProduLocationSide  from Products where ProductCode =" + PCode);
            string locationSide = dataTable.Rows[0]["ProductDescription"].ToString();
            return locationSide;
        }

       
        public string GetCompanyByProductCode(string PCode)
        {
            RunQueriesOnDB connect = new RunQueriesOnDB();
            DataTable dataTable = connect.RunAnySqlQueryOnDB("select ProduCompany  from Products where ProductCode =" + PCode);
            string locationCompany = dataTable.Rows[0]["ProductDescription"].ToString();
            return locationCompany;
        }
    }
}


   


