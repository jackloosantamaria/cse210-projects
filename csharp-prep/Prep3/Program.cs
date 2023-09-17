using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Core Requirement #1
        Console.WriteLine("What is the magic number? ");
        String magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);
        Console.WriteLine("What is your guess? ");
        string gnumber = Console.ReadLine();
        int guessNumber = int.Parse(gnumber);
        if (number > guessNumber){
            Console.WriteLine("Higher");
        }
        else if (number < guessNumber){
            Console.WriteLine("Lower");
        }
        else{
            Console.WriteLine("You guessed it!");
        }

    }
}