using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_ZhaoshengLiu
{
    class GUI
    {
        public static double Price { get; set; }
        public static double Number { get; set; }

        public static double Transaction { get; set; }
        public static void EnterTransactionLine()
        {
            Console.Write("Please input product price: ");
            Price = double.Parse(Console.ReadLine());

            Console.Write("Please input product number: ");
            Number = double.Parse(Console.ReadLine());
            Transaction = Price * Number;

        }

        public static void ShowMenu()
        {
            Console.WriteLine("Please input choose(A for add transaction line, D for delete transaction line, C for cancel transaction line)");
        }

        public static void ShowTransactionLine()
        {
            
            Console.WriteLine($"Price: {Price}, Number: {Number}, Acount: {Transaction}");
        }
    }
}
