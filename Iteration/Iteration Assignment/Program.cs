using System;
using System.Collections.Generic;

namespace Iteration_Assignment
{
    class Program
    {
        static void Main()
        {
            
            fruitIteration();
            Console.WriteLine();

            infiniteLoopAssignment();
            Console.WriteLine();

            uniqueItemsLoopAssignment();
            Console.WriteLine();

            doubleItemLoopAssignment();
            Console.WriteLine();

            musicGenreLoop();
        }

        // --- PART 1 ---

        private static void fruitIteration()
        {
            string[] fruits = { "orange", "banana", "kiwi", "apple", "strawberry" }; // creating a one-dimensional array
            Console.WriteLine("What is your favourite fruit? \n"); // Asking for a user's input
            string userFruit = Console.ReadLine().ToLower(); // storing user's input

            // Looping through an array and displaying each string on a separate line.
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine();

            // Creating a loop that iterates through each string in the array
            // and adds the user's text input to the end of each string.
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i] += " " + userFruit);
            }
        }
        
        // --- PART 2 ---
        private static void infiniteLoopAssignment()
        {
            //// creating an infinite loop 
            //for (int i = 0; i <= 10;) 
            //{
            //    Console.WriteLine("Hello!");
            //}

            // fixing the infinite loop so that it will execute properly
            for(int i = 0; i<=10; i++)
            {
                Console.WriteLine("Hello!");
            }
        }

        // --- PART 3 ---
        private static void uniqueItemsLoopAssignment()
        {
            // creating a list of strings with unique values, asking for user input.
            List<string> vegetables = new List<string>() { "lettuce", "spinach", "pepper", "carrot", "broccoli", "peas", "cucumber" };
            Console.WriteLine("Please write your favorite vegetable:");
            string userVegetable = Console.ReadLine().ToLower();

            // Creating A loop that iterates through the list and then
            // displays the index of the list that contains matching user input on the screen.
            int i = 0;
            bool veggieFound = false;
            while (i < vegetables.Count)
            {
                if (userVegetable == vegetables[i])
                {
                    veggieFound = true;
                    Console.WriteLine("The index of your favourite vegetable is " + i + ".");
                    break; // stops code from executing once the match has been found
                }
                i++;
            }
            // Tells a user if they put in text that isn't in the list.
            if(veggieFound == false)
            {
                Console.WriteLine("Sorry, that vegetable is not in the list.");
            }
                     
        }

        // --- PART 4 ---
        private static void doubleItemLoopAssignment()
        {
            // Creating a list of strings that has at least two identical strings in the list, asking for user input.
            List<string> months = new List<string>() { "February", "March", "June", "July", "March", "April", "June", "March" };
            Console.WriteLine("Please enter a month of your choice. Please capitalize the first letter.");
            string userMonth = Console.ReadLine();

            // Creating a loop that iterates through the list and then displays
            // the indices of the list that contain matching user input on the screen.
            int i = 0;
            bool monthFound = false;
            while (i < months.Count)
            {
                if (userMonth == months[i])
                {
                    monthFound = true;
                    Console.WriteLine("The index of that month is " + i + ".");
                }
                i++;
            }
            // Tells a user if they put in text that isn't in the list.
            if (monthFound == false)
            {
                Console.WriteLine("Sorry, that month is not in the list.");
            }


        }

        private static void musicGenreLoop()
        {
            // Creating a list of strings that has at least two identical strings in the list.
            List<string> musicGenresOne = new List<string>() { "rock", "pop", "opera", "blues", "pop", "country", "rock", "jazz", "opera", "rock" };
            
            // Creating a empty list where genres from the previous list will be added while looping through them.
            List<string> musicGenresTwo = new List<string>();

            // Create a foreach loop that evaluates each item in the list, 
            // and displays a message showing the string and whether or not it has already appeared in the list.
            foreach (string genre in musicGenresOne)
            {
                if(!musicGenresTwo.Contains(genre))
                {
                    musicGenresTwo.Add(genre);
                    Console.WriteLine("The genre " + genre + " appears for the first time.");
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
