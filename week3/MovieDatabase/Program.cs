using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializse Movie objects and Movies list
            List<Movie> movies = new List<Movie> {
                new Movie("Independence Day", "Sci Fi"),
                new Movie("Spirited Away", "Animated"),
                new Movie("Halloween", "Horror"),
                new Movie("Harry Potter", "Drama"),
                new Movie("Big Trouble in Little China", "Sci Fi"),
                new Movie("Interstellar 5555", "Animated"),
                new Movie("Scarecrow Gone Wild", "Horror"),
                new Movie("The King", "Drama"),
                new Movie("Ready Player One", "Sci Fi"),
                new Movie("Howl's Moving Castle", "Animated"),
                new Movie("Killer Clowns From Outer Space", "Horror"),
                new Movie("Call Me By Your Name", "Drama")
            };

            Console.Write("\nWelcome to the MovieDB!" +
                          "\nCategories:\n" +
                          " - Drama\n" +
                          " - Animated\n" +
                          " - Horror\n" +
                          " - Sci Fi");
            do
            {
                // prompt user to 
                Console.Write("\n\nPlease type a category to search by (leave blank to list all movies): ");

                // get input from user
                string category = Console.ReadLine().ToLower();

                // commenting out to save for future reference
                //foreach (Movie movie in movies.Where(movie => movie.GetCategory().ToLower().Contains(category)))
                //{
                //    Console.WriteLine(movie);
                //}

                // search and display movies
                SearchMovies(movies, category);

                // prompt user to continue
                Console.Write("\nWould you like to search the database again? (y/n) (default = n): ");

            // continue only if the y key is pressed
            } while (Console.ReadKey(false).Key == ConsoleKey.Y);
        }

        static void SearchMovies(List<Movie> movies, string category)
        {
            // create sub list of movies that match catgory
            List<Movie> matches = new List<Movie>(movies.Where(movie => movie.GetCategory().ToLower().Contains(category)));

            // print list if matches found
            if (matches.Count > 0)
            {
                int index = 1;
                Console.WriteLine($"\nFound {matches.Count} movies:");
                foreach (Movie movie in matches)
                {
                    Console.WriteLine($" {index++}: {movie}");
                }
            }
            // let user know no movies were found otherwise
            else
            {
                Console.WriteLine($"\nSorry, no movies match the category \"{category}\"");
            }
        }
    }
}
