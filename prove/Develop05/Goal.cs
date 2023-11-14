public class Goal{
    protected string _name;
    protected string _detail;
    protected int _point;
    protected bool _status;

    public Goal(){
        _status = false;
    }

    public Goal (string name, string detail, int point){
        _name = name;
        _detail = detail;
        _point = point;
    }

    public void GoalQuestions(){
        DisplayAnimation();
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        DisplayAnimation();
        Console.WriteLine("What is a short description of it? ");
        _detail = Console.ReadLine();
        DisplayAnimation();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _point = int.Parse(Console.ReadLine());

        _status = false;
    }

     public virtual string SaveGoal(){
        string line = "";
        return line;
     }

     public virtual void NewGoal(){}  

     public virtual void RecordEvent(){}

     public virtual bool IsComplete(){
        return false;
     } 

     public virtual void ListGoal(){}

     public virtual int Math(){
        return 0;
     }

     public void DisplayAnimation(){
     

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