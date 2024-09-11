using System.IO;

namespace classdemo0828array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing movie information");

            


            

        
        
          
               // Create an array of tuples to store movie information
                var movies = new (int id, string title, int year, double rating, string director)[]
                {
            (1, "The Shawshank Redemption", 1994, 9.3, "Frank Darabont"),
            (2, "The Godfather", 1972, 9.2, "Francis Ford Coppola"),
            (3, "The Dark Knight", 2008, 9.0, "Christopher Nolan"),
            (4, "Pulp Fiction", 1994, 8.9, "Quentin Tarantino"),
            (5, "The Lord of the Rings: The Return of the King", 2003, 8.9, "Peter Jackson")
                };

                // Loop through the array and print each movie's information
                foreach (var movie in movies)
                {
                    Console.WriteLine($"ID: {movie.id}");
                    Console.WriteLine($"Title: {movie.title}");
                    Console.WriteLine($"Year: {movie.year}");
                    Console.WriteLine($"Rating: {movie.rating}");
                    Console.WriteLine($"Director: {movie.director}");
                Console.WriteLine(new string('-', 40)); // Separator lin
            }
            }
        }




    }


