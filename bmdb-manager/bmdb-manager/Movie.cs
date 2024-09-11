namespace bmdb_manager
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public double rating { get; set; }
        public string director { get; set; }



        public Movie() { }

        public Movie(int id, string title, int year, double rating, string director)
        {
            this.id = id;
            this.title = title;
            this.year = year;
            this.rating = rating;
            this.director = director;
        }






        public override string ToString()
        {
            return $"Movie: id - '{this.id}', title - '{this.title}', year - '{this.year}',  rating - '{this.rating}' , director - '{this.director}'";
        }
    }

}





