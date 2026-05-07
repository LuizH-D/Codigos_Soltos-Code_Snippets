using System.Globalization;

namespace Bank {
    internal class Account {
        private int _nextNumber = 1;
        private string AccountNumber;
        private string AccountHolder;
        private decimal Balance;

    
        //Constructors
        public Account(string name) {
            AccountHolder = name;
            AccountNumber = _nextNumber++.ToString("D6");
        }
        public Account(string name, decimal balance) : this(name) {
            Balance = balance;
        }


        //Methods      
        public void Deposit(decimal amount) {
            Balance += amount;
        }
        public void Withdraw(decimal amount) {
            Balance -= amount + 5.00M;
        }

        public override string ToString() {
            return "Account "
                + AccountNumber
                + ", Account Holder: "
                + AccountHolder
                + ", Balance: $"
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
