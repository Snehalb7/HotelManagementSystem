using System.Security.Cryptography.X509Certificates;
//-----Summary
//A Small Mini Project for Hotel Management System with Restaurant Module.
//It allows users to view the menu, place orders, view their orders, and calculate the total bill.
//The program uses a simple console interface for interaction.
namespace HotelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int selectedOption = 0;
            Restaurant restaurant = new Restaurant();
            Console.WriteLine("----------Welcome to the S-Caffe----------");
            do
            {
                Console.WriteLine("1.Display Menu");
                Console.WriteLine("2.Place Order");
                Console.WriteLine("3.View Order");
                Console.WriteLine("4.Bill");
                Console.WriteLine("5.Exit");
                Console.WriteLine("-----------------------------------------");
                selectedOption = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (selectedOption)
                    {
                        case 1:
                            restaurant.DisplayMenu();
                            break;
                        case 2:
                            restaurant.PlaceOrder();
                            break;
                        case 3:
                            restaurant.DisplayOrder();
                            break;
                        case 4:
                            double totalBill = 0;
                            foreach (var orderItem in restaurant.orderItems)
                            {
                                totalBill += orderItem.GetTotalPrice();
                            }
                            Console.WriteLine($"Total Bill: {totalBill}");
                            break;
                        case 5:
                            Console.WriteLine("Thank you for visiting S-Caffe. Have a great day!");
                            Environment.Exit(0);
                            break;
                        default:
                             Console.WriteLine("Invalid option. Please select a valid option number.");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input. Please enter a valid option number."+e.Message);
                }

            } while (selectedOption <= 5);
        }
    }
}
