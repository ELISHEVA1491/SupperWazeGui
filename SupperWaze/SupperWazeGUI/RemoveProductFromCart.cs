using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SupperWazeGUI
{
    public partial class RemoveProductFromCart : ResourceDictionary
    {
        SupperWazeBL.FunctionBL fuc = new SupperWazeBL.FunctionBL();
        public void MouseRightButtonDown(object sender, EventArgs e)
        {
            if (MessageBox.Show("?האם אתה בטוח שברצונך להסיר מוצר זה מהעגלה", "", MessageBoxButton.YesNo, MessageBoxImage.None, MessageBoxResult.No, MessageBoxOptions.RightAlign) == MessageBoxResult.Yes)
            {
                int pro_code = fuc.GetProductCodeByProductName((sender as TextBlock).Text);
                SupperWazeENTITIES.LastShopping p = Forms.TheSoppingMenu.listToBuy.First(i => i.ProductCode == pro_code);
                SupperWazeGUI.Forms.TheSoppingMenu.listToBuy.Remove(p);

                SupperWazeGUI.Forms.ShowCart b = new Forms.ShowCart();
                b.RefrshList();
            }

        }
    }
}


