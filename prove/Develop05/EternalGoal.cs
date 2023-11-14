public class EternalGoal:Goal{
    private int _counter;

    public EternalGoal(){
        _counter = 0;
    }

    public EternalGoal(string name, string detail, int point): base(name, detail, point){
        _name = name;
        _detail = detail;
        _point = point;
        _counter = 0;
    }

    public override void NewGoal()
    {
        GoalQuestions();
    }

    public override void ListGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_detail})");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string SaveGoal()
    {
        string phrase = $"EternalGoal:," + _name + "," + _detail + "," + _point.ToString();
        return phrase;
    }

    public override void RecordEvent()
    {
        _counter++;
    }

    public override int Math()
    {
        int point = _point;
        return point;
    }
}