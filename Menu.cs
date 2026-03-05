using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    //This class represents a menu item in the restaurant, containing information about the menu ID, name, and price.
    public class Menu
    {
       public int menuId;
       public  string menuName;
       public int price;

      public  Menu(int menuId, string menuName, int price)
        {
            this.menuId = menuId;
            this.menuName = menuName;
            this.price = price;
        }
    }
}
