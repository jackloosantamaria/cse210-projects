public class SimpleGoal: Goal{
    
    public SimpleGoal(){
        _status = false;
    }

    public SimpleGoal(string name, string detail, int point, bool status): base(name, detail, point) {
        _status = status;
        _point = point;
        _detail = detail;
        _name = name;
    }

    public override void NewGoal()
    {
        GoalQuestions();
    }

    public override void RecordEvent()
    {
        if (_status == false){
            _status = true;
        }
        else {
            Console.WriteLine("You have previously completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_status == true){
            return true;
        }
        else {
            return false;
        }
    }

    public override void ListGoal()
    {
        string symbol;
        bool status = IsComplete();
        if (status == true){
            symbol = "X";
        }
        else{
            symbol = " ";
        }
        Console.WriteLine($"[{symbol}] {_name} ({_detail})");
    }

    public override int Math()
    {
        bool status = IsComplete();
        int gPoint;
        if (status == true){
            gPoint = _point;
        }
        else{
            gPoint = 0;
        }
        return gPoint;
    }

    public override string SaveGoal()
    {
        string phrase = $"SimpleGoal:,{_name},{_detail},{_point},{IsComplete().ToString()}";
        return phrase;
    }

}