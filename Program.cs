using System;

namespace calculatar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Toplama emelyati ucun + dail edin");
            Console.WriteLine("cixma emelyati ucun - dail edin");
            Console.WriteLine("vurma emelyati ucun * dail edin");
            Console.WriteLine("bolme emelyati ucun / dail edin");

            if (Console.ReadLine() == "+")
            {
                Console.Write("a-ni daxil et : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b-ni daxil et: ");
            int b= Convert.ToInt32(Console.ReadLine());

            Console.Write("cavab:  ");
            Console.WriteLine( a + b );

            }

            if  (Console.ReadLine() == "a")
            {
                Console.Write("a-ni daxil et : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b-ni daxil et: ");
            int b= Convert.ToInt32(Console.ReadLine());

            Console.Write("cavab: ");
            Console.WriteLine( a - b );

            }

            
           



        }
    }
}
