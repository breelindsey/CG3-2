using System;

namespace CG3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ask the user to guess a number between 1 and 10.
            If they enter 8, output You Win!.  Otherwise output You Lose. 
            Do this using an inline if statement. 
            Upload your program to a new repository called CG 3-2.*/

            
            Console.Write("Guess a number between 1-10: ");
            
            //This string assigns the variable 'guess' to the user input.
           string guess = Console.ReadLine();
           
            //This string tells the program how to respond to the user input.
            string message = (guess == "8") ? "You Win!" : "You Lose!";
           
            //This WriteLine prints the result of the user input.
            Console.WriteLine(message);
            Console.ReadLine();
        }
        
    }
}
