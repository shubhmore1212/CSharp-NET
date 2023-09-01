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
          Console.WriteLine("Please enter a limit of even number");
            int[] List = GetEvenNumbers(int.Parse(Console.ReadLine()));
            PrintNumbers(List);
        }

        static int[] GetEvenNumbers(int Limit)
        {
            int size = Limit/2;
            if (Limit % 2 == 1)
            {
                size++;
            }
          
            int[] EvenNumsList = new int[size];
            int Start = 0;
            for (int i = 0; i < size; i++)
            {
                EvenNumsList[i] = Start;
                Start += 2;
            }
            return EvenNumsList;
        }

        static void PrintNumbers(int[] Numbers)
        {
            foreach(int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }

  
}
