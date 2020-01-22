namespace CashRegister_ZhaoshengLiu
{
    internal class CancelTransactionLine : IAction
    {
        public double TransactionTotal { get; set; }

        public void ApplyAction(double transaction, ref double transactionTotal)
        {
        }
    }
}