using System;
using System.Threading;

namespace StickmanMovement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("  0");
            //Console.WriteLine("\\/|\\O");
            //Console.WriteLine(" / \\");

            string head1 = " 0 ";
            string body1 = "/|\\";
            string legs1 = "/ \\";
            string legs2 = " | ";
            bool legsShouldPrint = true;

            Console.WriteLine(head1);
            Console.WriteLine(body1);

            for (int i = 0; i < 33; i++)
            {
                Console.Clear();

                int offset = i + 3;

                Console.WriteLine(head1.PadLeft(offset, ' '));
                Console.WriteLine(body1.PadLeft(offset, ' '));

                if (legsShouldPrint)
                {
                    Console.WriteLine(legs1.PadLeft(offset, ' '));
                }
                else
                {
                    Console.WriteLine(legs2.PadLeft(offset, ' '));
                }

                legsShouldPrint = !legsShouldPrint;

                Thread.Sleep(150);
            }

            Console.ReadLine();        
        }
    }
}
