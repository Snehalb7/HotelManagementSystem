using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
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
