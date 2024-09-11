namespace bmdb_manager
{
    internal class Program
    {


        static List<Movie> movies = new List<Movie>();
        static List<Actor> actors = new List<Actor>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Creating Class 'Movie' by using Movie table from bmdb database");

            // define instances M1,M2,M3,M4,M5 in'Movie'class- .

            Movie m1 = new Movie(1, "The Shawshank Redemption", 1994, 9.4, "Frank Darabont");
            Movie m2 = new Movie(2, "The Godfather", 1972, 9.2, "Francis Ford Coppola");
            Movie m3 = new Movie(3, "The Dark Knight", 2008, 9.0, "Christopher Nolan");
            Movie m4 = new Movie(4, "Pulp Fiction", 1994, 8.9, "Quentin Tarantino");
            Movie m5 = new Movie(5, "The Lord of the Rings: The Return of the King", 2003, 8.9, "Peter Jackson");

            //Console.WriteLine($"m1 properties: id - {m1.id}, title - {m1.title}, year - {m1.year} ,rating -{m1.rating},director -{m1.director}");
            //m1.title = "The Pursuit of Happyness";
            //Console.WriteLine($"m1 properties: id - {m1.id}, title - {m1.title}, year - {m1.year} ,rating -{m1.rating},director -{m1.director}");
            // Console.WriteLine($"m1: {m1}");
            //Console.WriteLine($"m2: {m2}");
            // Console.WriteLine($"m3: {m3}");
            // Console.WriteLine($"m4: {m4}");
            // Console.WriteLine($"m5: {m5}");
            //Console.WriteLine("pass m1 directly to WriteLine: " + m1.ToString());
            // Console.WriteLine(m1);

            //Lists of movies

            movies.Add(m1);
            movies.Add(m2);
            movies.Add(m3);
            movies.Add(m4);
            movies.Add(m5);

            Console.WriteLine("List of movies:");
            foreach (Movie m in movies)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("Creating Class 'Actor' by using 'Actor' table from bmdb database");

            // define instances A1,A2,A3,A4,A5 in 'Actor' class- 

            Actor a1 = new Actor(1, "Christian", "Bale", "Male", new DateOnly(1974, 01, 30));
            Actor a2 = new Actor(2, "Heathe", "Ledger", "Male", new DateOnly(1979, 04, 04));
            Actor a3 = new Actor(3, "Leonardo", "Dicaprio", "Male", new DateOnly(1974, 11, 11));
            Actor a4 = new Actor(4, "Charlize", "Theron", "Female", new DateOnly(1975, 08, 07));



            //List of actors

            actors.Add(a1);
            actors.Add(a2);
            actors.Add(a3);
            actors.Add(a4);

            //Print list of actors

            Console.WriteLine("List of Actors:");
            foreach (Actor a in actors)
            {
                Console.WriteLine(a);
            }


            //Menu - display menu

            DisplayMenu();
            string option = "";
            while (option != "exit")
            {
                option = GetString("\nOption: ");
                Console.WriteLine();
                switch (option)
                {
                    case "menu":
                        DisplayMenu();
                        break;

                    case "show":
                        ShowMovies();
                        break;

                    case "add":
                        AddMovie();
                        break;

                    case "find":
                        FindMovieBYID();
                        break;

                    case "delete":
                        DelMovie();
                        break;

                    case "addactor":
                        Addactor();
                        break;
                    case "delactor":
                        DelActor();
                        break;
                    case "showactor":
                        ShowActor();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;



                }
            }
        }




        //Method for displayMenu()
        static void DisplayMenu()
        {
            Console.WriteLine("MOVIE MENU");
            Console.WriteLine("menu - Redisplay menu");
            Console.WriteLine("Show - Show all movies");
            Console.WriteLine("Add - Add a movie");
            Console.WriteLine("Delete- Delete a movie ");
            Console.WriteLine("Find -   Get a movie by movie id ");
            Console.WriteLine("Addactor -Add an actor");
            Console.WriteLine("Delactor -Add an actor");
            Console.WriteLine("Showactor -Add an actor");
            Console.WriteLine("exit - Exit program");
        }
    



        //Method for showing list of movies
        static void ShowMovies()
        {
            Console.WriteLine("Show All Movies:");
            Console.WriteLine("===============");
            for (int i = 0; i < movies.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i]}");
            }
        }

        //Method for delete a  movie
        static void DelMovie()
        {
            int Id;
            Console.WriteLine("Delete a movie:");
            Console.WriteLine("=============");
            // drop: prompt user for movie id #,
            Id = GetInt("Enter the id of movie to delete");
            // remove item by #,
            Movie movieToRemove = movies.Find(m => m.id == Id);

            movies.Remove(movieToRemove);
            Console.WriteLine($"{movieToRemove} was dropped.");
        }


        // Method to add  a movie
        public static void AddMovie()
        {
            Console.WriteLine("Add a new movie:");

            int id = GetInt("Enter movie ID: ");
            string title = GetString("Enter movie title: ");
            int year = GetInt("Enter release year: ");
            double rating = GetDouble("Enter movie rating: ");
            string director = GetString("Enter movie director: ");

            Movie newMovie = new Movie(id, title, year, rating, director);

            if (newMovie != null)
            {
                movies.Add(newMovie);
                Console.WriteLine($"Movie '{newMovie.title}' added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid movie. Cannot add to the list.");
            }
        }
        // Method to find movie by id

        public static void FindMovieBYID()
        {
            int id = GetInt("Enter the ID of the movie to find: ");
            Movie movie = movies.Find(m => m.id == id);

            if (movie != null)
            {
                Console.WriteLine($"Movie found: {movie}");
            }
            else
            {
                Console.WriteLine($"Movie with ID {id} not found.");
            }
        }

        // Method to add an Actor to the Actors list

        public static void Addactor()
        {
            Console.WriteLine("Add a new Actor to the list:");

            int id = GetInt("Enter Actor ID: ");
            string FirstName = GetString("Enter First Name: ");
            string LastName = GetString("Enter Last Name:  ");
            String Gender = GetString("Enter Gender: ");
            DateOnly birthdate = DateOnly.Parse(GetString("Enter  Actor's birthdate: "));

            Actor newActor = new Actor(id, FirstName, LastName, Gender, birthdate);

            if (newActor != null)
            {
                actors.Add(newActor);
                Console.WriteLine($"Actor '{newActor.FirstName}{newActor.LastName}' added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid Actor. Cannot add to the list}.");
            }
        }


        //Method to delete actor by id

        static void DelActor()
        {
            int Id;
            Console.WriteLine("Delete an actor:");
            Console.WriteLine("=============");
            // drop: prompt user for movie id #,
            Id = GetInt("Enter the id of actor to delete");
            // remove item by #,
            Actor actorToRemove = actors.Find(a => a.id == Id);

            actors.Remove(actorToRemove);
            Console.WriteLine($"{actorToRemove} was dropped.");
        }

        //Method for showing list of Actors
        static void ShowActor()
        {
            Console.WriteLine("Show All Actors from the list:");
            Console.WriteLine("===============");
            for (int i = 0; i < actors.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {actors[i]}");
            }
        }





        private static int GetInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        private static double GetDouble(string prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }


        // Method for GetString

        public static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();

        }



    }

}

















































