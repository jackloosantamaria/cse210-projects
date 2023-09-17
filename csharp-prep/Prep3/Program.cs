using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Core Requirement #1
        /*Console.Write("What is the magic number? ");
        String magicNumber = Console.ReadLine();
        int number = int.Parse(magicNumber);
        Console.Write("What is your guess? ");
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
        }*/

        //Core Requirement #2

        /*int guessNumber;
        int number;

        

        Console.Write("What is the magic number? ");
        String magicNumber = Console.ReadLine();
        number = int.Parse(magicNumber);
        do{
            Console.Write("What is your guess? ");
            string gnumber = Console.ReadLine();
            guessNumber = int.Parse(gnumber);
            if (number > guessNumber){
                Console.WriteLine("Higher");
            }
            else if (number < guessNumber){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        }while (guessNumber != number);*/

        //Core Requirement #3

        int guessNumber;
        int number;

        Random randomGenerator = new Random();
        number = randomGenerator.Next(1,100);
        Console.WriteLine(number);

        
        do{
            Console.Write("What is your guess? ");
            string gnumber = Console.ReadLine();
            guessNumber = int.Parse(gnumber);
            if (number > guessNumber){
                Console.WriteLine("Higher");
            }
            else if (number < guessNumber){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You guessed it!");
            }
        }while (guessNumber != number);


    }
}