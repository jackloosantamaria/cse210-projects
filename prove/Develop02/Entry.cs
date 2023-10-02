public class Entry{

    public string _choiceNumber;
    public string _dateTime;
    public string _userPrompt;
    public string _userEntry;
    public string _userFile;

    public Entry(){

    }

    public void Display(){
        Console.Write($"Date: {_dateTime} - Prompt: {_userPrompt}");
        Console.Write($"{_userEntry}");
    }
}