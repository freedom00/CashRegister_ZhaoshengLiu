using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_ZhaoshengLiu
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKeyInfo;
            CashRegister cashRegister = new CashRegister();

            cashRegister.StartRegister();
            // get the right key, if the key is "Y", it will close the cash register and show the total acount.
            do
            {
                cashRegister.DoTransactionLine();

                Console.Write($"Please input 'Y', if you want to close cash register: ");
                consoleKeyInfo = Console.ReadKey();
                Console.WriteLine();
            } while (consoleKeyInfo.Key != ConsoleKey.Y);

            cashRegister.CloseRegister();
            Console.ReadKey();
        }
    }
}
