using System;


namespace PriceQuote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below." + '\n');
            Console.WriteLine("Please enter the package weight:");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight <= 50)
            {

                Console.WriteLine("Please enter the package width:");
                int packWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int packHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package lenght:");
                int packLenght = Convert.ToInt32(Console.ReadLine());

                if ((packWidth + packHeight + packLenght) > 50) {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else if ((packWidth + packHeight + packLenght) <= 50)
                {
                    int packQuote = ((packHeight * packWidth * packLenght) * packWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is £" + packQuote + ".00");
                    Console.ReadLine();
                }

            }

            else if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.ReadLine();


        }
    }
}
