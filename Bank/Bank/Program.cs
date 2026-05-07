using System.Globalization;

namespace Bank {
    class Program {
        static void Main(string[] args) {
            string name; string initialDeposit; decimal amount = 0; Account account;

            //Account Holder Name
            do {
                Console.Write("Enter the account holder: ");
                name = Console.ReadLine();
                if(string.IsNullOrEmpty(name) || name.Any(char.IsDigit)) {
                    Console.WriteLine("The name cannot be empty or contain digits");
                }
            } while(string.IsNullOrEmpty(name) || name.Any(char.IsDigit));

            // Initial Deposit

            do {
                Console.Write("Will there be an initial deposit (y/n): ");
                initialDeposit = Console.ReadLine().Replace(" ", "").ToLower();

                if(string.IsNullOrEmpty(initialDeposit) || initialDeposit != "y" && initialDeposit != "n") {
                    Console.WriteLine("Invalid option! Type 'y' or 'n'");
                }
            } while(string.IsNullOrEmpty(initialDeposit) || initialDeposit != "y" && initialDeposit != "n");

            if(initialDeposit == "y") {
                do {
                    Console.Write("Enter the initial deposit amount: ");
                    amount = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if(amount <= 0.00M) {
                        Console.WriteLine("Enter an amount greater than zero");
                    }
                } while(amount <= 0.00M);
                account = new Account(name,amount);
                Console.WriteLine($"Account data:\n{account}");
            }
            else {
                account = new Account(name);
                Console.WriteLine($"Account data:\n{account}");
            }

            //Deposit
            do {
                Console.Write("Enter a deposit amount: ");
                amount = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(amount <= 0.00M) {
                    Console.WriteLine("Enter an amount greater than zero");
                }
            } while(amount <= 0.00M);
            account.Deposit(amount);
            Console.WriteLine($"Updated account data:\n{account}");

            //Withdraw
            do {
                Console.Write("Enter a withdrawal amount: ");
                amount = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(amount <= 0.00M) {
                    Console.WriteLine("Enter an amount greater than zero");
                }
            } while(amount <= 0.00M);
            account.Withdraw(amount);
            Console.WriteLine($"Updated account data:\n{account}");
        }
    }
}