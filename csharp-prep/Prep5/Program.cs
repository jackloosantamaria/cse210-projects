using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String Username = PromptUserName();
        int Numbers = PromptUserNumber();
        int newSqNumb = SquareNumber(Numbers);
        DisplayResult(Username, newSqNumb);
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName(){
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
        
    }

    static int SquareNumber (int squareNum){
        int newNum = squareNum * squareNum;
        return newNum;
    }

    static void DisplayResult(String userName, int finalNumber){
        Console.Write($"{userName}, the square of your number is {finalNumber}");
        
    }

}