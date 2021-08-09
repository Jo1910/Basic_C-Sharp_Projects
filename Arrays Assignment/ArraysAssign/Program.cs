using System;
using System.Collections.Generic;


namespace ArraysAssign
{
    class Program
    {
        static void Main()
        {
            // This assignment calls for creating a one-dimensional array of strings, array of integers
            // and a list of strings, asking for a user input and displaying the value of that index.



            // Array of strings
            string[] colors = { "red", "blue", "green", "yellow" }; //creating an array of strings
            Console.WriteLine("Please select a number between 0 and 3 to choose a color: "); // asking for user input
            int userIndex = Convert.ToInt32(Console.ReadLine()); // storing user input as an integer

            while(userIndex < 0 || userIndex > 3) // continue looping while the user's input is less than 0 or larger than 3
            {
                Console.WriteLine("Value not found. Please try again.");
                Console.WriteLine("Please select a number between 0 and 3 to choose a color: "); // asking for user input
                userIndex = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine("You chose " + colors[userIndex] + ".\n");
            Console.ReadLine();

            // Array of integers
            int[] myIntArray = { 12, 3, 45, 22, 8 };
            Console.WriteLine("Please select an index between 0 and 4 to display a number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            while(userNumber < 0 || userNumber > 4)
            {
                Console.WriteLine("Value not found. Please try again.");
                Console.WriteLine("Please select an index between 0 and 4 to display a number: ");
                userNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You chose " + myIntArray[userNumber] + ".\n");
            Console.ReadLine();


            // List of strings
            List<string> myStrList = new List<string> { "Austria", "Belgium", "Ireland", "Columbia", "Canada" }; //initiating a list of strings
            myStrList.Add("Greece"); // adding a variable to the list of strings

            Console.WriteLine("Please select an index between 0 and 5 to display a country: ");
            int userCountry = Convert.ToInt32(Console.ReadLine());

            while(userCountry < 0 || userCountry > 5)
            {
                Console.WriteLine("Value not found. Please try again.");
                Console.WriteLine("Please select an index between 0 and 5 to display a country: ");
                userCountry = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You chose " + myStrList[userCountry] + ".");
            Console.ReadLine();
                
        }
    }
}
