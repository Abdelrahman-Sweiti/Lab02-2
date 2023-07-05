using System;

namespace Lab02
{
    public class Program
    {
        public static decimal Balance { get; set; }

        static void Main(string[] args)
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Welcome to the ATM");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        decimal balance = ViewBalance();
                        Console.WriteLine($"Current Balance: {balance}");
                        break;
                    case "2":
                        Console.WriteLine("Enter the amount to withdraw:");
                        decimal withdrawAmount;
                        if (!decimal.TryParse(Console.ReadLine(), out withdrawAmount))
                        {
                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                            break;
                        }
                        Withdraw(withdrawAmount);
                        break;
                    case "3":
                        Console.WriteLine("Enter the amount to deposit:");
                        decimal depositAmount;
                        if (!decimal.TryParse(Console.ReadLine(), out depositAmount))
                        {
                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                            break;
                        }
                        Deposit(depositAmount);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static decimal ViewBalance()
        {
            return Balance;
        }

        public static void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a positive value.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds. Unable to withdraw.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}");
        }

        public static void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Invalid amount. Please enter a non-negative value.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Successfully deposited {amount}");
        }
    }
}
