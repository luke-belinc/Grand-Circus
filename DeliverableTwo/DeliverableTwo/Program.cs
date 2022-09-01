using System;
// uncomment below if using .Where()
//using System.Linq;

namespace DeliverableTwo
{
    class Program
    {
        public static void Main(string[] args)
        {
            // variable to store input history
            string history = "";

            // enter main loop
            do
            {
                // prompt user to say something
                Console.Write("Say something: ");
                string input = Console.ReadLine().ToLower();
                // could use String.Concat and .Where to get rid of unnecessary white space
                // string input = String.Concat(Console.ReadLine().ToLower().Where(c => !Char.IsWhiteSpace(c)));

                // check to see if user already "said that"
                if (history == input)
                {
                    // notify user
                    Console.WriteLine("I’m sorry, but you have already said that...\n");
                    // not sure if im supposed to reset history here, but i will add it commented out just in case
                    //history = "";
                    // continue to beginning of loop
                    continue;
                }

                // add user input to history
                history = input;

                // repsond according to user input
                switch(input)
                {
                    case "sup":
                        Console.WriteLine("I am good\n");
                        break;
                    case "hello":
                        Console.WriteLine("Hi good to see you\n");
                        break;
                    case "hello there":
                    // if removing whitespace use:
                    //case "hellothere":
                        Console.WriteLine("General Kenobi\n");
                        break;
                    case "bye":
                        Console.WriteLine("Good bye!\n");
                        break;
                    default:
                        Console.WriteLine("Invalid input: \"" + input + "\"\n");
                        break;
                }

                // break loop if user said "bye"
                if (input == "bye") break;

            } while (true);
        }
    }
}
