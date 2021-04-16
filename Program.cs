using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssign
{
    class Program
    {
        static void Main()
        {
            string firstName = "Sarah";
            string lastName = "Dean";
            string occupation = "admin";

            // string concenation
            string sentence = (firstName + " " + lastName + " is an " + occupation + " in this company.");
            Console.WriteLine(sentence);
            Console.ReadLine();

            // converting to uppercase
            sentence = sentence.ToUpper();
            Console.WriteLine(sentence);
            Console.ReadLine();

            //stringBuilder

            StringBuilder sb = new StringBuilder("Once upon a time there lived for cows in the forest.");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append(" Every day they used to graze together in a particular spot.");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append(" They were all friends.");
            Console.WriteLine(sb);
            Console.ReadLine();

            sb.Append(" One day a lion saw the cows grazing together.");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
