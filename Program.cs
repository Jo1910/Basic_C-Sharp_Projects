using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PitmanDailyReports
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pitman Training \nStudent Daily Report\n\nPress enter to continue");
            Console.ReadLine();
                    Console.WriteLine("What course are you in?");
                    string courseName = Console.ReadLine();
                    int page;
                    Console.WriteLine("What page number?");
                    page = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
                    string help = Console.ReadLine();
                    Console.WriteLine("Were there any positive experiences you'd like to share? Please provide specifics.");
                    string experience = Console.ReadLine();
                    Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
                    string feedback = Console.ReadLine();
                    int hours;
                    Console.WriteLine("How many hours did you study today?");
                    hours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Thank you for your responses. An instructor will reply to you shortly. Have a great day!");
                    Console.ReadLine();
        }
    }
}
