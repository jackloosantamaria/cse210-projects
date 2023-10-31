public class Activity{
    private string _newActivity;
    private int _designatedTime;
    
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
       
            Console.Write("Awesome! ");
            for (int i=0; i<50; i++){
                List<string>animationString = new List<string>();
                animationString.Add("|");
                animationString.Add("/");
                animationString.Add("-");
                animationString.Add("\\");
                foreach (string s in animationString){
                    Console.Write(s);
                    Thread.Sleep(75);
                    Console.Write('\b');          
            }
        
        }
            
    
        Console.WriteLine($"Good job! You have completed another {_designatedTime} seconds of the {_newActivity} Activity!");
    }

    public void DisplayAnimation(){
     

        for (int i=0; i<20; i++){
            List<string>animationString = new List<string>();
            animationString.Add("|");
            animationString.Add("/");
            animationString.Add("-");
            animationString.Add("\\");
            foreach (string s in animationString){
                Console.Write(s);
                Thread.Sleep(100);
                Console.Write('\b');
            
            
            }
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
      
         Console.Write("Get Ready! ");
            for (int i=0; i<20; i++){
                List<string>animationString = new List<string>();
                animationString.Add("|");
                animationString.Add("/");
                animationString.Add("-");
                animationString.Add("\\");
                foreach (string s in animationString){
                    Console.Write(s);
                    Thread.Sleep(100);
                    Console.Write('\b');  
                } 
            }
    }
}