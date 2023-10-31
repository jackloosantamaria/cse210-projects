public class Activity{
    private string _newActivity;
    private int _designatedTime;
    //private string _timeMessage;
    private string _text;

    public Activity(string newActivity){
        _newActivity = newActivity;
        _text = "You may start in";
    }
    public Activity(){}

    public int GetActivityTime(){
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _designatedTime = seconds;
        return seconds;
    }

    public void WelcomeActivityMessage(){
        Console.WriteLine($"Welcome to the {_newActivity} Activity\n");
    }

    public void DisplayFinalMessage(){
        int timer = 0;
        for (int i = 0; i < 50; i++){
            switch (timer % 4){
                case 0: Console.Write("Good job! /"); break;
                case 1: Console.Write("Good job! -"); break;
                case 2: Console.Write("Good job! \\"); break;
                case 3: Console.Write("Good job! |"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 11, Console.CursorTop);
            timer++;
            Thread.Sleep(75);
        }
        Console.WriteLine($"You have completed another {_designatedTime} seconds of the {_newActivity} Activity!");
    }

    public void DisplayAnimation(){
        var timer = 0;
        for (int i = 0; i < 50; i++){
            switch (timer % 4){
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            timer++;
            Thread.Sleep(100);
        }
    }


    public void DisplayCounter(int time){
        for (int i = time; i > 0; i--){
            Console.Write($"{_text} {i}");
            Thread.Sleep(1000);
            string space = new string('\b',  (_text.Length +5) );
            Console.Write(space);
        }
        Console.WriteLine($"Go:     ");
    }

    public void DisplayAnimationReady(){
        int timer = 0;
        for (int i = 0; i < 50; i++){
            switch (timer % 4){
                case 0: Console.Write("Get Ready! /"); break;
                case 1: Console.Write("Get Ready! -"); break;
                case 2: Console.Write("Get Ready! \\"); break;
                case 3: Console.Write("Get Ready! |"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);
            timer++;
            Thread.Sleep(75);
        }
    }
}