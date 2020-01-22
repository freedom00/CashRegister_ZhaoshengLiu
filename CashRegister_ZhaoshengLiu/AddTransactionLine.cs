namespace CashRegister_ZhaoshengLiu
{
    internal class AddTransactionLine : IAction
    {
        public double TransactionTotal { get; set; }

        public void ApplyAction(double transaction, ref double transactionTotal)
        {
            transactionTotal = transactionTotal + transaction;
        }
    }
}