using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    public class Restaurant
    {
        public List<Menu> menuList { get; set; } = new List<Menu>();
       public List<OrderItem> orderItems { get; set; } =new List<OrderItem>();


        Menu m1 = new Menu(1, "ColdCoffee", 40);
        Menu m2 = new Menu(2, "Pizza", 150);
        Menu m3 = new Menu(3, "GreenTea", 30);
        Menu m4 = new Menu(4, "Burger", 130);
        Menu m5 = new Menu(5, "FrenchFries", 100);

        public void ListOfItems()
        {
            menuList.Add(m1);
            menuList.Add(m2);
            menuList.Add(m3);
            menuList.Add(m4);
            menuList.Add(m5);

        }
        public void DisplayMenu()
        {
            ListOfItems();
            Console.WriteLine("Menu:");
            foreach (var menu in menuList)
            {
                Console.WriteLine($"MenuId: {menu.menuId}, MenuName: {menu.menuName}, Price: {menu.price}");
            }
            Console.WriteLine("-----------------------------------------");
            
        }

        public void DisplayOrder()
        {
            Console.WriteLine("Order Details:");
            foreach (var orderItem in orderItems)
            {
                Console.WriteLine(orderItem.ToString());
               
            }

        }
        public void PlaceOrder()
        {


            // take user input for placing order
            Console.WriteLine("Enter MenuId to place order:");
            int menuId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            ListOfItems();
            int qty = Convert.ToInt32(Console.ReadLine());
            Menu selectedMenu = menuList.Find(m => m.menuId == menuId);

            
            if (selectedMenu != null)
            {
               // PlaceOrder(Id,menu,Qty);
                Console.WriteLine(" Your Order placed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid MenuId. Please try again.");
            }
            Console.WriteLine("-----------------------------------------");
            
            Console.WriteLine("Your Order Details:");
            Console.WriteLine("MenuId: {0}, MenuName: {1}, Price: {2}, Quantity: {3}", selectedMenu.menuId, selectedMenu.menuName, selectedMenu.price, qty);

            Console.WriteLine("-----------------------------------------");
            OrderItem orderItem = new OrderItem(selectedMenu.menuId, selectedMenu, qty);
            orderItems.Add(orderItem);
        }
    }
}
