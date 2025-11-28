using System;
using System.Collections.Generic;

namespace RomanNumeralsConverter
{
    internal class Program
    {
        public static Dictionary<int, string> romanDictionary = new Dictionary<int, string>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to convert");

            string input = Console.ReadLine();
            int inputNumber = int.Parse(input);

            ConvertNumber(inputNumber);

            Console.ReadKey();
        }

        static void ConvertNumber(int number)
        {
            string result = "";
            int romanNumber = number;

            foreach (KeyValuePair<int,string> roman in romanDictionary)
            {
                //While the number is greater or equal to item key/number
                // Example number = 12 if greater or equal to 10, roman number hits 10
                // adds the value from 10 and takes away 10 left with 2. and 2 stops at 1 and adds 1 roman value
                while (romanNumber >= roman.Key) //romanDictionary[10] = X, romanDictionary[1] = I 
                {
                    //Then add the roman string value 
                    result += roman.Value;
                    //Then take away with the key
                    romanNumber -= roman.Key;
                }
            }

            Console.WriteLine($"Roman number : {number} = {result}");
        }
    }
}
