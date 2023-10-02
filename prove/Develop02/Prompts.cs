public class Prompts{

    public static string[] _options = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public List<string> _Prompts = new List<string>(_options);

    public Prompts(){

    }

    public string ShowPrompt(){

        var random = new Random();
        int number = random.Next(_Prompts.Count);
        string Prompts = _Prompts[number];
        return Prompts;
    }

    public void Display(){
        var random = new Random();
        int number = random.Next(_Prompts.Count);
        string Prompts = _Prompts[number];
        Console.WriteLine($"\n{_Prompts}");
    }

}