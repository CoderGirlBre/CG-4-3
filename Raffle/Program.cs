using System;

namespace Raffle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Allows the user to enter up to 30 names.
            Console.WriteLine("Enter up to 30 names: ");

            //This puts the names that the user will enter into an array.
            string[] names = new string[30];

           //Declaring a new variable for later use.
            int z = 0;

            //This loops the array 30 times.
            for (int x = 0; x < 30; x++)

            {
                //Assigning the names the user entered to a new variable called names[x].
                names[x] = Console.ReadLine();

                //This tells the console that the user is done entering names if they
                //hit enter without entering a name.
                if (names[x] == "") break;

                //Without this, the winner would always be the first name that the user entered.
                z += 1;
            } //New random created.
            Random rnd1 = new Random();

            //This pulls a random name from the array and assigns it to the variable y.
            int y = rnd1.Next(z);

            //This writes a random name from the names entered to the console, which is the winner.
            Console.WriteLine("Winner: " + names[y]);

            //This is here to create a line of space in the console window before doing the next thing.
            Console.WriteLine();

            //This loops the names to 30 again.
            for (int x = 0; x < 30; x++)
            { 
                //"If they didn't enter a name there or the loop is empty or it was the winner
                //don't print it to the console."
                //This prints the loser's to the console.
                if (names[x] == string.Empty || names[x] == null || names[x] == names[y]) continue;
                Console.WriteLine("Loser: " + names[x]);
                
            }
            Console.ReadLine();
        }
    }
}
