using System.Diagnostics;

public class ReflectingActivity: Activity{

    private string _randomPrompt = "ReflectingPrompt.txt";
    private string _randomPrompt2 = "InquiryList.txt";
    //private string _inquiryList;
    private string _secondMessage;
    private List<ReflectingActivity> _prompts = new List<ReflectingActivity>();
    private List<ReflectingActivity> _questions = new List<ReflectingActivity>();
    private string _startNumber;
    private string _startNumber2;
    private string _data;
    private string _data2;
    private int _number;
    private int _number2;
    private string _promptText;
    private string _promptText2;


    public ReflectingActivity():base(){}

    public ReflectingActivity(string newActivity): base(newActivity){
        _secondMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void SetSecondMessage(){
        Console.WriteLine($"{_secondMessage}\n");
    }

    public void LoadPrompts(){
        List<string> readingFile = File.ReadAllLines(_randomPrompt).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
        foreach (string i in readingFile){
            string [] newEntry = i.Split(";");
            ReflectingActivity entries = new ReflectingActivity();
            entries._startNumber = newEntry[0];
            entries._data = newEntry[1];
            _prompts.Add(entries);
    }
    }

    public void LoadQuestions(){
        List<string> readingFile = File.ReadAllLines(_randomPrompt2).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
        foreach (string i in readingFile){
            string [] newEntry2 = i.Split(";");
            ReflectingActivity entries2 = new ReflectingActivity();
            entries2._startNumber2 = newEntry2[0];
            entries2._data2 = newEntry2[1];
            _questions.Add(entries2);
    }
    }

    public int GetPromptReflecting(){
        var ranm = new Random();
        _number = ranm.Next(_prompts.Count);
        return _number;
    }

    public string DisplayRandomPromptReflecting(){
        _number = GetPromptReflecting();
        return _promptText = _prompts[_number]._data;
    }

    public int GetInquiryList(){
        var ranm = new Random();
        _number2 =  ranm.Next(_questions.Count);
        return _number2;
    }

    public string DisplayInquiry(){
        _number2 = GetInquiryList();
        return _promptText2 = _questions[_number2]._data2;
    }

    public void DisplayQuestion(int time){
        
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        DisplayCounter(8);
        Console.Clear();
        Stopwatch clock = new Stopwatch();
        clock.Start();
        while(clock.Elapsed.TotalSeconds < time){
            if (_questions.Count != 0){
                var inquiry = DisplayInquiry();
                Console.Write($"\n{inquiry}\n");
                //_questions.Remove(inquiry);
            }
            DisplayAnimation();
        }
        clock.Stop();
    }

    public void DisplayEverything(int time){
        var show = DisplayRandomPromptReflecting();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"\n{show}");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        if (input == ""){
            DisplayQuestion(time);
        }
    }


}