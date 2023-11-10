namespace WinFormsApp2
{
    public class Transaction
    {
        public decimal Balance
        {
            set
            {
                if (value > 0.0m)
                    Balance = value;
            }
            get { return Balance; }
        }
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m)
            {
                Balance += depositAmount;
            }
        }
        public void Withdraw(decimal withdrawAmount)
        {
            if (withdrawAmount <= Balance && withdrawAmount > 0.0m)
            {
                Balance -= withdrawAmount;
            }
        }
        /* public void Transfer(decimal transferAmount,Transaction obj)
         {
             Account myAccount = new Account();
             Account accountTransferred = new Account();
             myAccount.Account_Number();

         }*/
    }
}

