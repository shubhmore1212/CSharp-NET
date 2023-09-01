using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Please enter a valid number");
          PrintNumbers(int.Parse(Console.ReadLine()));  
        }

        static void PrintNumbers(int number)
        {
            int Start = 0;
            string MyVar = "";

            while (Start <= number)
            {
                Console.Write(Start + " ");
                Start += 2;
            }
            Console.WriteLine();
        }
    }

  
}
