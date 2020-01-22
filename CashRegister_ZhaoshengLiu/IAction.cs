namespace CashRegister_ZhaoshengLiu
{
    internal interface IAction
    {
        void ApplyAction(double transaction, ref double transactionTotal);
    }
}