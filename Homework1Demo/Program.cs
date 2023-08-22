using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please select an option (1-4) from below: ");
            Console.WriteLine();

            Console.WriteLine("1. Print even numbers.\n" +
                "2. Print divisible numbers.\n" +
                "3. Print words in Reverse order\n" +
                "4. Print word and character count in a sentence");

            Console.WriteLine();

            string selection = Console.ReadLine();

            if (selection == "1")
            {
                Console.Write("Please enter a number between 3-9: ");

                int numbersCount = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[numbersCount];

                AddNumbersToArray(numbers, numbersCount);
                PrintEvenNumbers(numbers);
            }

            else if (selection == "2")
            {
                Console.Write("Please enter a divisor number: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many numbers do you want to check divisible by " + divisor + ":");
                int numbersCount = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[numbersCount];

                AddNumbersToArray(numbers, numbersCount);
                PrintDivisibleNumbers(numbers, divisor);
            }

            else if (selection == "3")
            {
                Console.Write("How many words do you want to print reverse: ");
                int wordCount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Please write {wordCount} words: ");
                string text = Console.ReadLine();

                string[] words = text.Split();



                //AddWordsToArray(words, wordCount);
                PrintWordsReverse(words);
            }

            else if (selection == "4")
            {
                Console.WriteLine("Please write a sentence below to count its word & char count: ");

                string sentence = Console.ReadLine();
                string[] strings = sentence.Split();

                CountWords(strings);
                CountChars(strings);

            }



            Console.ReadLine();
        }


        public static void AddNumbersToArray(int[] arr, int counter)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please enter {0} numbers: ", counter);
                arr[i] = Convert.ToInt32(Console.ReadLine());
                counter--;
            }
        }

        public static void PrintEvenNumbers(int[] arr)
        {
            Console.Write("even numbers are: ");

            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {

                    Console.Write(num + " ");
                }

            }
        }

        public static void PrintDivisibleNumbers(int[] arr, int divisorNum)
        {
            Console.Write("divisible numbers by {0} are: ", divisorNum);

            foreach (int num in arr)
            {
                if (num % divisorNum == 0)
                {
                    Console.Write(num + " ");
                }
            }
        }

       
        public static void PrintWordsReverse(string[] arr)
        {
            Array.Reverse(arr);
            Console.WriteLine(String.Join(" ", arr));
        }

        public static void CountWords(string[] arr)
        {
            int wordCount = 0;
            foreach (string word in arr)
            {
                wordCount++;
            }
            Console.WriteLine($"Total words in the sentence are {wordCount}");
        }

        public static void CountChars(string[] arr)
        {
            int charCount = 0;
            foreach (string word in arr)
            {
                charCount += word.Length;
            }
            Console.WriteLine($"Total chars in the sentence are {charCount}");
        }


    }
}
