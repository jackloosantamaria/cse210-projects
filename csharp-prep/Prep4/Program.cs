using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num;
       
        List<int>list_numbers = new List<int>();
        
        do{
            Console.Write("Enter a number: ");
            String Numbers = Console.ReadLine();
            num = int.Parse(Numbers);
            list_numbers.Add(num);
            
       
        }while(num !=0);
        int sum = 0;   
        foreach (int i in list_numbers){
            sum += i; 
        }    
    Console.WriteLine($"The sum is: {sum}");
    
    //To get the average

   int Total = list_numbers.Count;
    int total2 = Total - 1;
    float suma = sum;
    float average = suma/total2;
    Console.WriteLine($"The average is: {average}");

    //to get max number

    int max = list_numbers[0];
    foreach (int i in list_numbers){
        if (i>max){
            max = i;
        }
    }
    Console.WriteLine($"The largest number is: {max}");
    }
}