using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CashRegister_ZhaoshengLiu
{
    class CashRegister
    {
        private double transactionTotal;
        public double TotalAmount { get; set; }
        public double TransactionTotal { get => transactionTotal; set => transactionTotal = value; }

        public CashRegister(double totalAmount = 0, double transactionTotal = 0)
        {
            TotalAmount = totalAmount;
            TransactionTotal = transactionTotal;
        }

        public void StartRegister()
        {
            Console.Write($"The total amount is: {TotalAmount}");
            Console.WriteLine();
        }

        public void CloseRegister()
        {
            Console.WriteLine($"The total amount is: {TotalAmount}");
        }

        public void DoTransactionLine()
        {
            Regex regex = new Regex(@"^[ADCadc]$");
            ConsoleKeyInfo consoleKeyInfo;
            IAction action = null;
            do
            {
                //get the right key.
                do
                {
                    GUI.ShowMenu();
                    consoleKeyInfo = Console.ReadKey();
                    Console.WriteLine();
                } while (!regex.IsMatch(consoleKeyInfo.Key.ToString()));

                //choose the right transaction operation.
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.A:
                        action = new AddTransactionLine();
                        break;
                    case ConsoleKey.D:
                        action = new DeleteTransactionLine();
                        break;
                    case ConsoleKey.C:
                        action = new CancelTransactionLine();
                        break;
                }
                if (consoleKeyInfo.Key != ConsoleKey.C)
                {
                    GUI.EnterTransactionLine();
                }
                GUI.ShowTransactionLine();
                action.ApplyAction(GUI.Transaction, ref transactionTotal);
                Console.WriteLine($"Transaction Total: {TransactionTotal}");
                
            } while (consoleKeyInfo.Key != ConsoleKey.C);
            TotalAmount += TransactionTotal;
            TransactionTotal = 0;
        }
    }
}
