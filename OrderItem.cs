using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class OrderItem
    {
       public int orderItemId;
        public Menu menu;
        public int quantity;
        public OrderItem(int orderItemId, Menu menu, int quantity)
        {
            this.orderItemId = orderItemId;
            this.menu = menu;
            this.quantity = quantity;
        }
        public double GetTotalPrice()
        {
            return menu.price * quantity;
        }

        public override string ToString()
        {
            return $"OrderItemId: {orderItemId}, Menu: {menu.menuName}, Quantity: {quantity}, Total Price: {GetTotalPrice()}";
        }

        
    }
}
