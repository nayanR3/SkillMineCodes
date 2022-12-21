using System;

namespace ArrayFolder
{
    /*Q1.WAP to sort character type of array. */
    class CharArrSort
    {
        static void Main(string[] args)
        {
            // Creating a Char Array
            System.Console.WriteLine("Size of array");
            int n = int.Parse(Console.ReadLine());

            char[] charArray = new char[n];
            System.Console.WriteLine("Enter array element");
            for (int i = 0; i < n; i++)
            {
                charArray[i] = Convert.ToChar(Console.ReadLine());
            }
            fun (charArray);
        }

        public static void fun(char[] charArray)
        {
            // Displaying Array before Sorting
            Console.WriteLine("\nChar Array Before Sorting");
            Console.WriteLine(string.Join(" ", charArray));

            // Sorting the Array
            for (int i = 0; i < charArray.Length - 1; i++)
            {
                for (int j = 0; j < charArray.Length - 1 - i; j++)
                {
                    if (charArray[j] > charArray[j + 1])
                    {
                        char t = charArray[j];
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = t;
                    }
                }
            }

            // Displaying Array after Sorting
            Console.WriteLine("\nChar Array After Sorting");
            Console.WriteLine(string.Join(" ", charArray));
        }
    }
}
