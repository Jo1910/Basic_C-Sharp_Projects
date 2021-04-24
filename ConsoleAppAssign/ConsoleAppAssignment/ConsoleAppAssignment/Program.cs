using System;
using System.Collections.Generic;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            //Part 1
            string[] fruits = { "Orange", "Banana", "Kiwi", "Apple", "Strawberry" };
            Console.WriteLine("Please enter your favourite fruit: \n");
            string userFruit = Console.ReadLine();

            for (int i = 0; i < fruits.Length; i++)
            {
                fruits[i] += " " + userFruit;
            }

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();

            // Comment out for an infinite loop
            //for(int i=0; i<=10; )
            //{
            //    Console.WriteLine("Hello");
            //}

            // Infinite loop fixed
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Hello");
            }

            // Loop with a "<" operator
            for (int j = 0; j < 15; j++)
            {
                Console.WriteLine("Apple \n");
            }

            // Loop with a "<=" operator
            for (int k = 0; k <= 10; k++)
            {
                Console.WriteLine("Blueberry \n");
            }
            Console.ReadLine();

            // Part 4
            List<string> vegetables = new List<string>() { "lettuce", "pepper", "cabbage", "carrot", "broccoli", "peas", "spinach", "potato", "cucumber", "corn", "zucchini" };
            Console.WriteLine("Please enter your favourite vegetable:");
            string userVeg = Console.ReadLine();

            int v = 0;
            bool veggieFound = false;
            while (v < vegetables.Count)
            {
                if (userVeg == vegetables[v])
                {
                    veggieFound = true;
                    Console.WriteLine("The index of your favourite vegetable is " + v);
                }
                v++;
            }
            if (veggieFound == false)
            {
                Console.WriteLine("Sorry, that vegetable is not in the list.");
            }
            Console.ReadLine();

            // Part 5
            List<string> months = new List<string>() { "Februrary", "April", "July", "March", "December", "April", "March", "June", "February", "March" };
            Console.WriteLine("Please enter a month of your choice. Please capitalize the first letter.");
            string userMonth = Console.ReadLine();

            int m = 0;
            bool monthFound = false;
            while (m < months.Count)
            {
                if (userMonth == months[m])
                {
                    monthFound = true;
                    Console.WriteLine("The month you entered has an index/indices: " + m);
                }
                m++;
            }
            if (monthFound == false)
            {
                Console.WriteLine("Sorry, that month is not in the list.");
            }
            Console.ReadLine();

            // Part 6
            List<string> musicGenre = new List<string>() { "country", "rock", "pop", "metal", "jazz", "rock", "opera", "disco", "opera", "rock", "blues", "jazz" };

            List<string> musicGenre1 = new List<string>();
            
            foreach (string genre in musicGenre)
            {
                if(!musicGenre1.Contains(genre))
                {
                    musicGenre1.Add(genre);
                    Console.WriteLine("The genre " + genre +" appears for the first time.");
                }
                else
                {
                    Console.WriteLine("The genre " + genre + " has already appeared in the list.");
                }
                Console.ReadLine();
            }
        }

    }
}
