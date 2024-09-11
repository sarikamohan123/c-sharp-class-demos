namespace bmdb_manager
{
    public class Actor

    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateOnly birthdate { get; set; }


        public Actor() { }

        public Actor(int id, string FirstName, string LastName, string Gender, DateOnly birthdate)




        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.birthdate = birthdate;
        }

        public override string ToString()
        {
            return $"Actor:  {id} :- {FirstName} {LastName} , {Gender}  Born on- {birthdate}";
        }

        /*public override string ToString()
        {
            return $"{id}: {FirstName} {LastName}, {Gender}, Born on {birthdate.ToString("MM-dd-yyyy")}";
        }*/




    }
}

