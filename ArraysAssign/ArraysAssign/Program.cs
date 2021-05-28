using System;
using System.Collections.Generic;


namespace ArraysAssign
{
    class Program
    {
        static void Main()
        {
            // Array of strings
            string[] myStrArray = { "Have", "a", "nice", "day" };
            Console.WriteLine("Please select an index of an array: ");
            int userIndex = Convert.ToInt32(Console.ReadLine());

            switch(userIndex)
            {
                case 0:
                    Console.WriteLine(myStrArray[0]);
                    break;
                case 1:
                    Console.WriteLine(myStrArray[1]);
                    break;
                case 2:
                    Console.WriteLine(myStrArray[2]);
                    break;
                case 3:
                    Console.WriteLine(myStrArray[3]);
                    break;
                default:
                    Console.WriteLine("Selected index doesn't exist.");
                    break;

            }

            // Array of integers
            int[] myIntArray = { 12, 3, 45, 22, 8 };
            Console.WriteLine("Please select an index of an array: ");
            int userIndex1 = Convert.ToInt32(Console.ReadLine());

            switch (userIndex1)
            {
                case 0:
                    Console.WriteLine(myIntArray[0]);
                    break;
                case 1:
                    Console.WriteLine(myIntArray[1]);
                    break;
                case 2:
                    Console.WriteLine(myIntArray[2]);
                    break;
                case 3:
                    Console.WriteLine(myIntArray[3]);
                    break;
                case 4:
                    Console.WriteLine(myIntArray[4]);
                    break;
                default:
                    Console.WriteLine("Selected index doesn't exist.");
                    break;
            }

            // List of strings
            List<string> myStrList = new List<string>();
            myStrList.Add("Hi");
            myStrList.Add("how");
            myStrList.Add("are");
            myStrList.Add("you");

            Console.WriteLine("Please select an index of an array: ");

            int userIndex2 = Convert.ToInt32(Console.ReadLine());

            switch (userIndex2)
            {
                case 0:
                    Console.WriteLine(myStrList[0]);
                    break;
                case 1:
                    Console.WriteLine(myStrList[1]);
                    break;
                case 2:
                    Console.WriteLine(myStrList[2]);
                    break;
                case 3:
                    Console.WriteLine(myStrList[3]);
                    break;
                default:
                    Console.WriteLine("Selected index doesn't exist.");
                    break;
            }
            Console.ReadLine();
                
            

        }
    }
}
