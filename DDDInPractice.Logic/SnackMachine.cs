namespace DDDInPractice.Logic
{
    public sealed class SnackMachine : Entity
    {

        public Money MoneyInside { get; private set; }

        public Money MoneyTransaction { get; private set; }

     
        public void InsertMoney(Money money )
        {
            MoneyTransaction += money;
        }


        public void ReturnMoney()
        {
          //  MoneyTransaction = 0;
        }

        public void BuySnack()
        {
            MoneyInside += MoneyTransaction;
            //  MoneyTransaction = 0;
        }

    }
}
