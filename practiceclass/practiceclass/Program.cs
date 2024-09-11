namespace practiceclass
{
    internal class Program
    {

        /* class Vehicle  // Base Class
         {
             public string? brand = "Ford";

             public void honk()
                 {

                 Console.WriteLine("Tuut..tuut");
                  }
         }
         class Car : Vehicle 
         { 
             // create fields
             int maxspeed;
             string? color;
             string? model;
             int year;

             //  create a class constructor fot the 'Car' classs
             public Car(string model, string color, int maxspeed, int year)
             {

                 this.model = model;
                 this.maxspeed = maxspeed;
                 this.color = color;
                 this.year = year;


             }



             static void Main(string[] args)
             {
                 Console.WriteLine("Hello, World!");

                 //Create an object of Car called myObj, and use it to set the value of maxSpeed to 200

                 Car myObj = new Car("Honda", "Red", 150, 2010);

                 Console.WriteLine(myObj.model);

                 //Car myObj2 = new Car();
                 // myObj2.color = "red";
                 // Console.WriteLine($" My Car's color is: {myObj2.color}");

                 // few more example
                 // Car Ford = new Car();
                 // Console.WriteLine($"My favorite model of of ford is : {Ford.model}");
                 // Console.WriteLine($"My favorite  car model's speed is  : {Ford.maxspeed}");

                 Car Toyota = new Car("Camry", "Red", 150, 2010);
                 Console.WriteLine($" My car details are as follows :\n{Toyota.model}\t{Toyota.color}\t{Toyota.maxspeed}\t{Toyota.year}");

                 // Console.WriteLine(myCar.brand + " " + myCar.modelName);
                 Car mycar = new Car("Mustang", "yellow",200,2020);
                 Console.WriteLine($" My car brand is {mycar.brand}, and its model is {mycar.model}");

                 mycar.honk();







                 //Call the fullThrottle() method from the object:

                 myObj.fullThrottle();


             }

             //Method fullThrottle
             public void fullThrottle()
             {
                 Console.WriteLine(" The car is going as fast as it can be!");

             }



         }*/

        //--------------------------------------------------------------------------
        /* class Animal
        //Base Class The animal makes a sound
        //The pig says: wee wee
        //The dog says: bow wow
        {
            public  virtual void animalsound() //method
            {
                Console.WriteLine(" The animal makes a sound");
            }
        }

        class Pig : Animal //Derived class (child)
        {

            public  override void animalsound() //Method
            {
                Console.WriteLine("The pig says :- Wee-Wee");
            }
        }

        class Dog : Animal
        {

            public  override void animalsound()// Method

            {

                Console.WriteLine(" The dog say :- bow wow");
            }
        }


        static void Main(string[] args) 
        {
            Animal MyAnimal = new Animal(); // creating  Animal object myAnimal
            Animal Mypig = new Pig(); // creating pig object
            Animal MyDog = new Dog();  // creating dog object

            MyAnimal.animalsound();
            Mypig.animalsound();
            MyDog.animalsound();
        } */



         abstract class Animal // Abstract class  cannot create object
        //Base Class The animal makes a sound
        //The pig says: wee wee
        //The dog says: bow wow
        {
            public abstract void animalsound(); //method //Abstract method doesnt have a body
            public void sleep()// Regular method
                {
                Console.WriteLine("ZZZ");
                }
           
        }

        class Pig : Animal //Derived class (child)
        {

            public override void animalsound() //Method
            {
                Console.WriteLine("The pig says :- Wee-Wee");
            }
        }

        class Dog : Animal
        {

            public override void animalsound()// Method

            {

                Console.WriteLine(" The dog say :- bow wow");
            }
        }


        static void Main(string[] args)
        {
           // Animal MyAnimal = new Animal(); // cannot create  object myAnimal in abstract class Animal
            Animal Mypig = new Pig(); // creating pig object
            Animal MyDog = new Dog();  // creating dog object

           
            Mypig.animalsound();
            Mypig.sleep();
            MyDog.animalsound();
            MyDog.sleep();
        }


    }
}

