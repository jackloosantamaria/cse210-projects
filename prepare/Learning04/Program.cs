using System;

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Learning04 World!");
            Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
            Console.WriteLine(assignment1.GetSummary());
            MathAssignment ma2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
            Console.WriteLine(ma2.GetSummary());
            Console.WriteLine(ma2.GetHomeworkList());
            WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        }
    }
