using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        GoalRecord goal = new GoalRecord();
        Console.Clear();
        int _num = 0;
        //int _number = 0;
        while(_num !=6){
            _num = Options();
            Console.Clear();
            Console.Write($"You currently have {goal.TotalMath()} point.\n");
            switch (_num){
                case 1:
                    int _number = 0;
                    while(_number !=4){
                    _number = Options2();
                    Console.Clear();
                    switch (_number){
                        case 1:
                            SimpleGoal gSimple = new SimpleGoal();
                            gSimple.NewGoal();
                            goal.addGoal(gSimple);
                        break;
                            
                        case 2:
                            EternalGoal gEternal = new EternalGoal();
                            gEternal.NewGoal();
                            goal.addGoal(gEternal);
                        break;

                        case 3: 
                           ChecklistGoal gChecklist = new ChecklistGoal();
                           gChecklist.NewGoal();
                           goal.addGoal(gChecklist);
                        break;

                        case 4:
                            
                        break;
                        }
                    }
                break;

                case 2:
                    goal.ListGoals();
                break;

                case 3:
                    goal.SaveGoals();        
                break;

                case 4:
                    goal.LoadGoals();
                break;

                case 5:
                    goal.RecordEvents();
                break;

                case 6:
                    Environment.Exit(0);
                    Console.WriteLine("Bye");
                break;

            }
        }
    }

    static int Options(){
        string options = @"
        Menu Options: 
            1. Create New Goal
            2. List Goals
            3. Save Goals
            4. Load Goals
            5. Record Event
            6. Quit
        Select a choice from the menu: ";
        Console.WriteLine(options);
        string answer = Console.ReadLine();
        int num;
        num = int.Parse(answer);
        return num;
    }

    static int Options2(){
        string options = @"
        The type goals are: 
            1. Simple Goal
            2. Eternal Goal
            3. Checklist Goal
            4. Exit
        Which type of goal would you like to create?: ";
        Console.WriteLine(options);
        string answer = Console.ReadLine();
        int number;
        number = int.Parse(answer);
        return number;
    }


}