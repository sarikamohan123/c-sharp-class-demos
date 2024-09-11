namespace interfacepractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Rabbit rabbit = new Rabbit();
            rabbit.flee();
            Hawk hawk = new Hawk();
            hawk.hunt();
            Fish fish = new Fish();
            fish.flee();
            fish.hunt();    
            
            
        }


        interface IPrey
        {
            public void flee();
        }

        interface IPredator
        {
            public void hunt();
        }
        class Rabbit: IPrey
        {
            public void flee()
            {
                Console.WriteLine(" The rabbit runs away!");
            }
                

        }
        
           
          

        class Hawk:IPredator
        { public void hunt()
            {
                Console.WriteLine(" The Hawk is searching for food!");
            }

        }

        class Fish :IPrey, IPredator
        
        {
            public void flee()
            {
                Console.WriteLine("The fish swims away");
            }
            public void hunt()
            {
                Console.WriteLine(" The fish finds another fish");
            }


        }
    }
}
