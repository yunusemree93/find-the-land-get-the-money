using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Find The Lang Get The Money ");
            int player = 0;
            int pc = 0;
            Random rastgele = new Random();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("It's your turn, specify the number >> Game: " + i);
                int number = Convert.ToInt32(Console.ReadLine());
                if ((number < 1) || (number > 3))
                {
                    i--;
                    Console.WriteLine("Enter the number in the specified range [1,3]");
                    continue;

                }

                int number1 = rastgele.Next(1, 3);
                Console.WriteLine("Computer Predicts ... Selecting Number >> Game " + i);
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine(number1);

                if (number != number1)
                {
                    player = player + 10;
                    Console.WriteLine("Standings -- Player: " + player);
                    Console.WriteLine("Standing -- PC: " + pc);
                }
                else if (number == number1)
                {
                    pc = pc + 10;
                    Console.WriteLine("Standings > PC: " + pc);
                    Console.WriteLine("Standings > Player: " + player);
                }
            }
            Console.Clear();
            Console.WriteLine("Computer Score : " + pc);
            Console.WriteLine("Player Score : " + player);

            Console.ReadLine();
        }
    }
}
