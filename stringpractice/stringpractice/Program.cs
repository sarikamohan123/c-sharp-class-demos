namespace stringpractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Functions");

            // anyone WHO takes more THAN thirty minutes for lunch is UNPROFESSIONAL.
            // convert above string to all lower case
            string firststring = "anyone WHO takes more THAN thirty minutes for lunch is UNPROFESSIONAL.";
            string newstring = firststring.ToLower();
            Console.WriteLine($"all in lowercase : {newstring}");


            // create a new string from the above that starts with a capital 'A'

            string newString1 = "A" + newstring.Substring(1);
            Console.WriteLine($" Start with capital A : {newString1}");


            // create a new string where replace thirty with sixty
            string newString2 = newString1.Replace("thirty", "sixty");
            Console.WriteLine($" Replace : {newString2}");

            //create a variable  that contains "fourty". Use that variable inthe above string in place of "sixty" using a placeholder. 
            string replacement = "fourty";
            string newSentence = newString2.Replace("sixty", $"{replacement}");
            Console.WriteLine(newSentence );

        }
    }
}
