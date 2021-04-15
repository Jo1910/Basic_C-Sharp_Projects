using System;

namespace LoopsAssignment
{
    class Program
    {
        static void Main()
        {
            // While loops
            Console.WriteLine("How many languages are spoken in the world today?");
            int languages = Convert.ToInt32(Console.ReadLine());
            bool spokenLang = languages == 7139;

            while(!spokenLang)
            {
                switch(languages)
                {
                    case 1000:
                        Console.WriteLine("There are many more. Try again.");
                        Console.WriteLine("How many languages are spoken in the world today?");
                        languages = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5000:
                        Console.WriteLine("More than that. Try again.");
                        Console.WriteLine("How many languages are spoken in the world today?");
                        languages = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 6500:
                        Console.WriteLine("You are almost there. Keep guessing.");
                        Console.WriteLine("How many languages are spoken in the world today?");
                        languages = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7139:
                        Console.WriteLine("That's correct!");
                        spokenLang = true;
                        break;
                    default:
                        Console.WriteLine("That's incorrect.");
                        Console.WriteLine("How many languages are spoken in the world today?");
                        languages = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
