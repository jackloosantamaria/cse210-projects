using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letter = "";
        /*if (number >= 90){
            Console.WriteLine("Your grade is an A. Congratulations! You passed the course");
        }
        else if (number >=80 && number < 90){
            Console.WriteLine("Your grade is a B. Congratulations! You passed the course");
        }
        else if (number >= 70 && number < 80){
            Console.WriteLine("Your grade is a C. Congratulations! You passed the course");
        }
        else if(number >= 60 && number < 70){
            Console.WriteLine("Your grade is a D. You've failed the course. Please do your best next time.");
        }
        else {
            Console.WriteLine("Your grade is F. You've failed the test. Please do your best next time.");
        }*/


        if (number >= 90){
            letter = "A";
        }
        else if (number >=80 && number < 90){
            letter = "B";
        }
        else if (number >= 70 && number < 80){
            letter = "C";
        }
        else if(number >= 60 && number < 70){
            letter = "D";
        }
        else {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (number >=70){
            Console.WriteLine("You passed!");
        }
        else {
            Console.WriteLine("You've failed. Please do your best next time.");
        }


    }
}