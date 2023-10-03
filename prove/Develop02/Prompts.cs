using System.Reflection.Metadata.Ecma335;

public class Prompts{

    public static string[] _options = {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What's on my mind today? "
    };


    public List<string> _prompts = new List<string>(_options);

    public Prompts(){

    }

    public string ShowPrompt(){

        var random = new Random();
        int number = random.Next(_prompts.Count);
        string Prompts = _prompts[number];
        return Prompts;
    }



}