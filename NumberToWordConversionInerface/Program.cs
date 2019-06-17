using System;
using NumberSystem;

namespace NumberToWordConversionInerface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to convert to words: ");
            Double n = Double.Parse(Console.ReadLine());
            ConversionNumberToWords objNumber = new ConversionNumberToWords();
            Console.WriteLine("{0}",objNumber.ConvertNumberToWords(n));
            Console.Read();
        }
    }
}
