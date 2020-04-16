using System;

namespace ComplexNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Complex complex = new Complex(4,2,'h');

            Console.WriteLine($"{complex.AddTwoComPlex(6,17,'i')}");
            Console.WriteLine($"{complex.SubTwoComPlex(1,11,'i')}");
                }
    }
}
