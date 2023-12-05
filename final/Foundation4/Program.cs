using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");

        List <Exercise> newList = new List<Exercise>();

        Running running = new Running("December 04, 2023", 45, 6.1);
        newList.Add(running);

        StationaryBicycles stationarybicycles = new StationaryBicycles("December 01, 2023", 50, 20);
        newList.Add(stationarybicycles);

        Swimming swimming = new Swimming("December 10, 2023", 35, 25);
        newList.Add(swimming);

        Console.WriteLine("Exercises: \n");
        foreach (Exercise exercise in newList){
            Console.WriteLine(exercise.GetSummary());
        }
    }
}