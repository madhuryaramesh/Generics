using System;

namespace Generics
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("THE GENERICS PROGRAM ");

            //UC1- INTEGER MAXIMUM
            Console.WriteLine("FIND THE MAXIMUM INTEGER NUMBER!");
            int output = UC1_IntegerMax.MaximumIntegerNumber(11, 5, 40);
            Console.WriteLine(output);


        }
    }
}
