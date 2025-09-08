// HW1a Sales Total

// Your Name: Dail Kinslow
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double salesTax = 0.085;

            Console.WriteLine("Please enter the item that you are purchasing.");
            string item = Console.ReadLine();
            Console.WriteLine($"How many {item}(s) would you like to purchase?");
            int amountItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What is the price of each{item}");
            double itemPrice = Convert.ToDouble(Console.ReadLine());

            double subTotal = amountItem * itemPrice;
            double salesTaxTotal = subTotal * salesTax;
            double total = subTotal * salesTax + (subTotal);
            Console.WriteLine($"Your subtotal is: {subTotal}");
            Console.ReadKey();
        }
    }
}
