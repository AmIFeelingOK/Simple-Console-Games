using System;

namespace ConsoleFightingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 70;
            int enemyHp = 55;

            int playerAttack = 5;
            int enemyAttack = 8;

            int healedAmount = 4;

            Random random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("---Player turn---");
                Console.WriteLine($"Player HP -> {playerHp}, Enemy HP -> {enemyHp}");
                Console.WriteLine("Enter 'A' to Attack or 'H' to Heal\n");

                char choice = char.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choice == 'A')
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine($"Player attack enemy and deals {playerAttack} damage\n");
                }
                else if (choice == 'H')
                {
                    playerHp += healedAmount;
                    Console.WriteLine($"Player restores {healedAmount} HP\n");
                }
                else
                {
                    Console.WriteLine("Invalid command. Please enter an action again.");
                    continue;
                }

                if (enemyHp > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("---Enemy turn---");
                    Console.WriteLine($"Player HP -> {playerHp}, Enemy HP -> {enemyHp}\n");

                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine($"Enemy attacks and deals {enemyAttack} damage!\n");
                    }
                    else if(enemyChoice == 1)
                    {
                        enemyHp += healedAmount;
                        Console.WriteLine($"Enemy restores {healedAmount} HP\n");
                    }
                }
            }

            if (playerHp > 0)
            {
                Console.WriteLine("Congratiolations, you have won!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
