using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TrafficLight
{
    class Program
    {
        
        static void Main(string[] args)
        { 
            
            
            while (true) // تكرار مستمر
            {
                // أحمر
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                stars();
                Console.ResetColor();
                Thread.Sleep(2000); // انتظر 2 ثانية

                // أصفر
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                stars();
                Console.ResetColor();
                Thread.Sleep(1000); // انتظر ثانية

                // أخضر
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                stars();
                Console.ResetColor();
                Thread.Sleep(2000); // انتظر 2 ثانية
            }
        }
        public static void stars()
        {
            
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i<=5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j<=5; j++)
                {
                    Console.Write(" * ");

                }
                Console.WriteLine();
            }
        }

    }
}
