using System.Diagnostics;
using System.Globalization;

public class ListingActivity : Activity {
    private string _randomPrompt = "prompts.txt";
    private List<string> _userPrompt = new List<string>();
    private string _thirdMessage;
    private List<ListingActivity> _randomWords = new List<ListingActivity>();
    private string _startNumber;
    private string _data;
    private int _number;
    private string _promptText;

    public ListingActivity(string newActivity): base(newActivity){
        _thirdMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void SetThirdMessage(){
        Console.WriteLine($"{_thirdMessage}\n");
        
    }

    public ListingActivity(): base(){}

    public void LoadWords(){
        List<string> readingFile = File.ReadAllLines(_randomPrompt).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
        foreach (string i in readingFile){
            string [] newEntry = i.Split(";");
            ListingActivity entries = new ListingActivity();
            entries._startNumber = newEntry[0];
            entries._data = newEntry[1];
            _randomWords.Add(entries);
    }
    }

    public int GetRandomPrompt(){
        var ranm = new Random();
        _number = ranm.Next(_randomWords.Count);
        return _number;
    }

    public string GetAleatoryPrompt(){
        _number = GetRandomPrompt();
        return _promptText = _randomWords[_number]._data;
    }

    public void DisplayRandomPrompt(int time){
        var ask = GetAleatoryPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" {ask} ");
        DisplayCounter(8);
        ShowTimeCounter(time);
    }

    public void ShowTimeCounter(int time){
        Stopwatch clock =  new Stopwatch();
        clock.Start();
        while (clock.Elapsed.TotalSeconds < time){
            Console.Write(">+");
            _userPrompt.Add(Console.ReadLine());
        }
        clock.Stop();
        int answerLength = _userPrompt.Count;
        Console.WriteLine($"You have listed {answerLength} items");

    }

}