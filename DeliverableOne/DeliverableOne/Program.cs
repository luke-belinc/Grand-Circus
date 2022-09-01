using System;

namespace DeliverableOne
{
    class Program
    {
        public static void Main(string[] args)
        {
            // enter main loop
            do
            {
                // get unit type
                Console.Write("Please enter unit type: ");
                string unit = Console.ReadLine();

                // get unit amount
                Console.Write("Please enter amount: ");
                double value = double.Parse(Console.ReadLine());

                // remove plurality from unit
                if (unit == "inches") unit = "inch";
                else if (unit == "fidget spinners") unit = "fidget spinner";
                else if (unit == "feet") unit = "foot";
                else if (unit == "memes") unit = "meme";

                // convert unit and ouput result
                switch (unit)
                {
                    case "fidget spinner":
                        value /= 3.5;
                        Console.WriteLine("\n" + value + ((value > 1 || value < 1) ? " inches" : " inch"));
                        break;
                    case "inch":
                        value *= 3.5;
                        Console.WriteLine("\n" + value + ((value > 1 || value < 1) ? " figdet spinners" : " fidget spinner"));
                        break;
                    case "foot":
                        value *= 5;
                        Console.WriteLine("\n" + value + ((value > 1 || value < 1) ? " memes" : " meme"));
                        break;
                    case "meme":
                        value /= 5;
                        Console.WriteLine("\n" + value + ((value > 1 || value < 1) ? " feet" : " foot"));
                        break;
                    default:
                        Console.WriteLine("\nIncorrect unit type \"" + unit + "\"");
                        break;
                }

                // update quit flag
                Console.Write("\nDo you want to convert more units? (yes/no) (default = no) ");
                string input = Console.ReadLine();

                // break loop if not continuing
                if (input != "yes") break;

                // add extra line for clean output
                Console.WriteLine();

            // continue as long as input does not equal yes
            } while (true);
        }
    }
}
