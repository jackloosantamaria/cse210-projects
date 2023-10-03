public class Entry{

    public string _choiceNumber;
    public string _dateTime;
    public string _userPrompt;
    public string _userEntry;


    public Entry(){

    }

    public void Display(){
        Console.WriteLine($"Date: {_dateTime} - Prompt: {_userPrompt}");
        Console.WriteLine($"{_userEntry}");
        
    }
}