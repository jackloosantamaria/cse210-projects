public class BreathingActivity : Activity{
    private string _openingMessage;
    private string _inMessage;
    private string _outMessage;

    public BreathingActivity(string newActivity) : base (newActivity){
        _inMessage = "Breathe in...";
        _outMessage = "Breathe out...";
        _openingMessage = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on our breathing";

    }

    public void SetOpeningMessage(){
        Console.WriteLine($"{_openingMessage}\n");
    }

    public void Breath(int time){
        Console.WriteLine("");
        int timer = 0;
        while (timer < time){
            for (int i = 3; i > 0; i--){
                Console.Write($"{_inMessage}{i}");
                Thread.Sleep(1000);
                string space = new string('\b',(_inMessage.Length + 2));
                Console.Write(space);
                timer +=1;
            }
            Console.WriteLine($"{_inMessage} ");
            for (int i = 5; i > 0; i--){
                Console.Write($"{_outMessage}{i}");
                Thread.Sleep(1000);
                string space = new string('\b',(_outMessage.Length +2));
                Console.Write(space);
                timer +=1;
            }
            Console.WriteLine($"{_outMessage} ");
        }
    }    
}