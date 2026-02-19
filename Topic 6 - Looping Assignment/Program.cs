namespace Topic_6___Looping_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            bool done = false;

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Welcome to the program.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Simple Banking Machine");
                Console.WriteLine("...");
                Console.WriteLine("3 - Exit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.Clear();

                if (choice == "1")
                {
                    prompter();

                }
                else if (choice == "2")
                {
                    simpleBankingMachine();
                }
                else if (choice == "3")
                {
                    done = true;
                    Console.WriteLine("Thanks for trying out my Program!");
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }

            }
        }

        public static void prompter()
        {
            int max;
            int min;

            Console.WriteLine("Please provide me with a maximum value: ");
            Console.WriteLine();
            while (!Int32.TryParse(Console.ReadLine(), out max) || max < 0)
            {
                 Console.WriteLine("You must have entered a negative number or letter. Please put in a positive value");
                 Console.WriteLine();
                 Console.WriteLine();
            }

            Console.WriteLine("Please provide me with a minimum value: ");
            Console.WriteLine();
            while (!Int32.TryParse(Console.ReadLine(), out min) || min < 0)
            {
                Console.WriteLine();
                Console.WriteLine("You must have entered a negative number or letter. Please put in a positive value");
                Console.WriteLine();
            }

            if (max < min)
            {
                (max, min) = (min, max);
            }

            int inBetween;

            Console.WriteLine($"Now, please enter a number between the {min} and {max} you just entered");
            while (!Int32.TryParse(Console.ReadLine(), out inBetween) || inBetween <= min || inBetween >= max)
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Try again and enter a number between your min and max");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press ENTER to Continue");
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void simpleBankingMachine()
        {
            double userBankBalance = 150;
            double bankTransationFee = 0.75;
            double depositAmount;
            double withdrawlAmount;
            string bill;
            string choice = "";
            bool done = false;

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Please enter the following transactions and type in the name:");
                Console.WriteLine();
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdrawl");
                Console.WriteLine("Bill Payment");
                Console.WriteLine("Account Balance Update");
                Console.WriteLine("...");
                Console.WriteLine("Quit");
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                Console.Clear();

                if (choice == "deposit")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    while (!Double.TryParse(Console.ReadLine(), out depositAmount) || depositAmount < 0)
                    {
                        Console.WriteLine("Invalid amount, Please enter another number");
                    }

                    userBankBalance = userBankBalance + depositAmount - bankTransationFee;

                    Console.WriteLine($"Your new total is {userBankBalance.ToString("C")}");
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER make another transaction");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (choice == "withdrawl")
                {
                    Console.WriteLine("How much would you like to take out?");
                    while (!Double.TryParse(Console.ReadLine(), out withdrawlAmount) || withdrawlAmount < 0)
                    {
                        Console.WriteLine("Invalid amount, Please enter another number");
                    }
                    userBankBalance = userBankBalance - withdrawlAmount - bankTransationFee;

                    if (userBankBalance <= 0)
                    {
                        userBankBalance = userBankBalance + withdrawlAmount - bankTransationFee;
                        Console.WriteLine();
                        Console.WriteLine("The amount you tried to withdrawl makes your balance after the transation fee less than 0. Withdrawl denied.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Your new balance after the withdrawl is {userBankBalance}");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Press ENTER make another transaction");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "bill payment")
                {
                    Console.WriteLine("What is the bill you are trying to pay for today?");
                    
                    Console.WriteLine();
                    Console.WriteLine("");
                    Console.ReadLine();
                }
                else if (choice == "account balance update")
                {
                    userBankBalance = userBankBalance - bankTransationFee;
                    Console.WriteLine($"Your balance is {userBankBalance.ToString("C")}");
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to do another transaction");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (choice == "Quit")
                {
                    Console.WriteLine("...");
                    done = true;
                }
                else 
                {
                    Console.WriteLine("This is for invalid input");
                }
            }


            Console.ReadLine();
        }

    }
}

