public class GoalRecord{
    private List<Goal> _achievement = new List<Goal>();
    private int _total;

    public GoalRecord(){
        _total = 0;
    }

    public int GetPoint(){
        int number = _total;
        return number;
    }

    public void SaveGoals(){
        DisplayAnimationReady();
        Console.Write("What is the filename for the goal file?: ");
        string textName = Console.ReadLine();
        using (StreamWriter text = new StreamWriter(textName)){
            int TotalNumber = GetPoint();
            text.WriteLine(TotalNumber.ToString());

            foreach(Goal goal in _achievement){
                text.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals(){
        
        _achievement.Clear();
        Console.Write("What is the filename for the goal file?: ");
        string textName = Console.ReadLine();
        string[] readLines = File.ReadAllLines(textName);
        _total = int.Parse(readLines[0]);
        //readLines = readLines.Skip(1).ToArray();
        for (int i = 1; i <readLines.Count(); i++){
            string[] section = readLines[i].Split(",");
            if (section[0] == "SimpleGoal:"){
                SimpleGoal gSimple = new SimpleGoal(section[1], section[2],int.Parse(section[3]), Convert.ToBoolean(section[4]));
                _achievement.Add(gSimple);
            }

            else if (section[0] == "EternalGoal:"){
                EternalGoal gEternal = new EternalGoal(section[1], section[2], int.Parse(section[3]));
                _achievement.Add(gEternal);
            }

            else if (section[0] == "ChecklistGoal:"){
                ChecklistGoal gChecklist = new ChecklistGoal(section[1], section[2], int.Parse(section[3]), int.Parse(section[4]), int.Parse(section[5]), int.Parse(section[6]));
                _achievement.Add(gChecklist);
            }
        }
    }

    public void ListGoals(){
        DisplayAnimationReady();
        Console.WriteLine("The goals are: ");
        for (int i = 0; i<_achievement.Count(); i++){
            Console.WriteLine($"{i+1}.");
            _achievement[i].ListGoal();
        }
        Console.WriteLine("");

    }

    public void addGoal(Goal goal){
        _achievement.Add(goal);
    }

    public int TotalMath(){
        int num = _total;
        foreach (Goal goal in _achievement){
            num += goal.Math();
        }

        _total = num;
        return num;
    }

    public void RecordEvents(){
        ListGoals();
        Console.WriteLine("Which goal did you accomplish? ");
        string index = Console.ReadLine();
        int goalIndex = int.Parse(index)- 1;

        if (_achievement[goalIndex].IsComplete()==false){
            _achievement[goalIndex].RecordEvent();
            int pointCompleted = _achievement[goalIndex].Math();
            _total += pointCompleted;
            Console.Write($"Awesome! You have earned {pointCompleted.ToString()} points.");
            Console.Write($"You now have {_total} points.");
            DisplayFinalMessage();
        }
        else {
            Console.WriteLine("You have already completed this goal.");
            DisplayFinalMessage();
        }
    }

        public void DisplayFinalMessage(){
       
            Console.Write(" Good Job! ");
            for (int i=0; i<50; i++){
                List<string>animationString = new List<string>();
                animationString.Add("|");
                animationString.Add("/");
                animationString.Add("-");
                animationString.Add("\\");
                foreach (string s in animationString){
                    Console.Write(s);
                    Thread.Sleep(75);
                    Console.Write('\b');          
            }
        
        }
    }

    public void DisplayAnimationReady(){
      
         Console.Write("Get Ready! ");
            for (int i=0; i<20; i++){
                List<string>animationString = new List<string>();
                animationString.Add("|");
                animationString.Add("/");
                animationString.Add("-");
                animationString.Add("\\");
                foreach (string s in animationString){
                    Console.Write(s);
                    Thread.Sleep(100);
                    Console.Write('\b');  
                } 
            }
    }

}