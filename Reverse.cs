using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            string input = Console.ReadLine();

            string reversedString = test(input);
            Console.WriteLine($"Output: {reversedString}");
        }

        public static string test(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray()).ToUpper();
        }
    }
}