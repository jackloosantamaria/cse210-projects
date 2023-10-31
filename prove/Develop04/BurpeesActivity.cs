using System.Formats.Asn1;

public class BurpeesActivity: Activity{

    private string _startingMessage;
    private string _closingMessage;
    private string _welcomingMessage;

    public BurpeesActivity(string newActivity): base (newActivity){
        _startingMessage = "Start in ...";
        _closingMessage = "Stop in...";
        _welcomingMessage  = "This high-intesity workout will help you strength the condition of your muscle, heart, and lungs.";
    }

    public void WelcomeMessage(){
        Console.WriteLine(_welcomingMessage);
    }

    public void Burpees(int time){
        int timer = 0;
        Console.WriteLine("Here are step-by-step instructions");
        Console.WriteLine("1. Begin in a standing position.\n 2. Drop into a squat.\n 3. Kick your legs back into a high plank position.\n 4. Lower toward the ground.\n 5. Rise back to high plank.\n 6. Return to a squat position.\n 7. Jump.");
        Console.WriteLine("Please press enter to continue");
        string answer = Console.ReadLine();
        if (answer == ""){
            while (timer < time){
                for (int i = 3; i > 0; i--){
                    Console.Write($"{_startingMessage}{i}");
                    Thread.Sleep(1000);
                    string space = new string('\b',(_startingMessage.Length + 2));
                    Console.Write(space);
                    timer +=1;
                }
                Console.WriteLine($"{_startingMessage} ");
                Thread.Sleep(10000);
                for (int i = 5; i > 0; i--){
                    Console.Write($"{_closingMessage}{i}");
                    Thread.Sleep(1000);
                    string space = new string('\b',(_closingMessage.Length +2));
                    Console.Write(space);
                    timer +=1;
                }
                Console.WriteLine($"{_closingMessage} ");
            }
        }
    }

}