using System;

namespace Generics
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("THE GENERICS PROGRAM ");

            //UC1- INTEGER MAXIMUM
            //Console.WriteLine("FIND THE MAXIMUM INTEGER NUMBER!");
            //int output = UC1_IntegerMax.MaximumIntegerNumber(11, 5, 40);
            //Console.WriteLine(output);

            //UC2- FLOAT MAXIMUM
            //Console.WriteLine("FIND THE MAXIMUM Float NUMBER!");
            //float floatoutput = (float)UC2_FloatMax.MaximumFloatNumber(2.3, 4.5, 6.6);
            //Console.WriteLine(floatoutput);

            //UC3- STRING MAXIMUM
            //Console.WriteLine("FIND THE MAXIMUM String Value!");
            //string stringoutput = (string)UC3_StringMax.MaximumString("apple ", "ball", "cat");  
            //Console.WriteLine(stringoutput);

            //UC4andUC5
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMax<int> gen = new GenericMax<int>(intArray);
            gen.PrintMaxValue();

            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMax<double> genDouble = new GenericMax<double>(doubleArray);
            genDouble.PrintMaxValue();

            string[] stringArray = { "111", "222", "333", "55", "999" };
            GenericMax<string> genString = new GenericMax<string>(stringArray);
            genString.PrintMaxValue();
        }
    }
}
