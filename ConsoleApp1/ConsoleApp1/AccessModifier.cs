using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AccessModifier
    {   
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }

        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }

        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal Method");
        }

        public void Test5()
        {
            Console.WriteLine("Public Method");
        }
        static void Main()
        {
            AccessModifier aM =new AccessModifier();

            aM.Test1();
            aM.Test2();
            aM.Test3();
            aM.Test4();
            aM.Test5();

            Console.ReadLine();
        }
    }
}
