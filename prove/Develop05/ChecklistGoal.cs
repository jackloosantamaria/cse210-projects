using System.Linq.Expressions;

public class ChecklistGoal:Goal{
    private int _bonusPoint;
    private int _counter;
    private int _amount;

    public ChecklistGoal(){}

    public ChecklistGoal(string name, string detail, int point, int bonusPoint, int amount, int Counter): base(name, detail, point){
        _name = name;
        _detail = detail;
        _point = point;
        _bonusPoint = bonusPoint;
        _amount = amount;
        _counter = Counter;
    }

    public override void NewGoal()
    {
        GoalQuestions();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _amount = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonusPoint = int.Parse(Console.ReadLine());

        _counter = 0;
    }

    public override bool IsComplete()
    {
        if (_counter >= _amount){
            return true;
        }
        else {
            return false;
        }
    }

    public override void RecordEvent()
    {
        _counter++;
    }

    public override int Math()
    {
        int point = _counter * _point;
        bool status = IsComplete();
        if (status == true){
            point += _bonusPoint;
        }
        return point;
    }

    public override void ListGoal()
    {
        string symbols;
        bool status = IsComplete();
        if (status == true){
            symbols = "X";
        }
        else{
            symbols = " ";
        }
        Console.Write($"[{symbols}] {_name} {_detail} -- Currently Completed {_counter}/{_amount}");

    }

    public override string SaveGoal()
    {
        string phrase = $"ChecklistGoal:," + _name + "," + _detail + "," + _point.ToString() + "," + _bonusPoint.ToString() + "," + _amount.ToString() + "," + _counter.ToString();
        return phrase;
    }
}