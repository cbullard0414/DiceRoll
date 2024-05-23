namespace DiceRoll
{
    using static System.Console;
    internal class Program
    {
        public static double diceroll;
        public static double balance = 500;
        public static double bet;
        public static double payout;
        public static double multiplier;
        public static int keepplaying = 1;
        static void Main(string[] args)
        {
            while (keepplaying == 1)
            {
                var rand = new Random();
                WriteLine("Welcome to the Coin Flip Gambling Machine!");
                WriteLine("Your current balance is: " + balance);
                WriteLine("How much would you like to bet?");
                bet = double.Parse(ReadLine());
                WriteLine("Your bet is: " + bet);
                WriteLine("Rolling the dice...");
                Thread.Sleep(3000);
                diceroll = rand.Next(5) + 1;
                Thread.Sleep(1000);
                WriteLine("Result: " + diceroll);
                Thread.Sleep(1000);

                if (diceroll == 1)
                {
                    multiplier = 0;
                }

                else if (diceroll == 2)
                {
                    multiplier = 0.5;
                }

                else if (diceroll == 3)
                {
                    multiplier = 1;
                }

                else if (diceroll == 4)
                {
                    multiplier = 1.25;
                }

                else if (diceroll == 5)
                {
                    multiplier = 1.5;
                }

                else if (diceroll == 6)
                {
                    multiplier = 2;
                }

                payout = (bet * multiplier);

                if (diceroll < 3)
                {
                    WriteLine("Better luck next time!");
                    balance = balance -= payout;
                    Thread.Sleep(500);
                    WriteLine("Your new balance is " + balance);
                }

                else if (diceroll == 3)
                {
                    WriteLine("You broke even!");
                    Thread.Sleep(500);
                    WriteLine("Your new balance is " + balance);
                }

                else if (diceroll > 3)
                {
                    WriteLine("Congratulations! You won " + payout + " dollars!");
                    balance = balance += payout;
                    Thread.Sleep(500);
                    WriteLine("Your new balance is " + balance);
                }

                WriteLine("Would you like to play again?");
                WriteLine("1 for Yes; 2 for No.");
                keepplaying = int.Parse(ReadLine());

            }
            WriteLine("Thanks for playing!");
            
        }
    }
}
