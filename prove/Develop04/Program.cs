using System;

class Program{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");

        //testing ListingActivity Class

        // Console.Clear();
        // ListingActivity listing = new ListingActivity("Listing");
        // listing.WelcomeActivityMessage();
        // listing.SetThirdMessage();
        // int time = listing.GetActivityTime();
        // listing.DisplayAnimation();
        // listing.LoadWords();
        // listing.DisplayRandomPrompt(time);
        // listing.DisplayFinalMessage();

        //testing BreathingActivity Class

        // Console.Clear();
        // BreathingActivity breathing = new BreathingActivity("Breathing");
        // breathing.WelcomeActivityMessage();
        // breathing.SetOpeningMessage();
        // int time = breathing.GetActivityTime();
        // breathing.DisplayAnimationReady();
        // breathing.Breath(time);
        // breathing.DisplayFinalMessage();

        //Testing BurpeesActivity Class - Stretch Challenge
        // Console.Clear();
        // BurpeesActivity burpee = new BurpeesActivity("Burpees");
        // burpee.WelcomeActivityMessage();
        // burpee.WelcomeMessage();
        // int time = burpee.GetActivityTime();
        // Console.Clear();
        // burpee.DisplayAnimationReady();
        // burpee.Burpees(time);
        // burpee.DisplayFinalMessage();

        //Testing ReflectingActivity Class

        // Console.Clear();
        // ReflectingActivity reflecting = new ReflectingActivity("Reflecting");
        // reflecting.WelcomeActivityMessage();
        // reflecting.SetSecondMessage();
        // int time = reflecting.GetActivityTime();
        // Console.Clear();        
        // reflecting.DisplayAnimationReady();
        // reflecting.LoadPrompts();
        // reflecting.LoadQuestions();
        // reflecting.DisplayEverything(time);
        // reflecting.DisplayFinalMessage();


      

    //Console.Clear();
    int _num = 0;
    while(_num !=5){
        _num = Options();
        Console.Clear();
        switch (_num){
            case 1:
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity("Breathing");
                breathing.WelcomeActivityMessage();
                breathing.SetOpeningMessage();
                int time = breathing.GetActivityTime();
                Console.Clear();
                breathing.DisplayAnimationReady();
                breathing.Breath(time);
                breathing.DisplayFinalMessage();
            break;

            case 2:
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting");
                reflecting.WelcomeActivityMessage();
                reflecting.SetSecondMessage();
                time = reflecting.GetActivityTime();
                Console.Clear();        
                reflecting.DisplayAnimationReady();
                reflecting.LoadPrompts();
                reflecting.LoadQuestions();
                reflecting.DisplayEverything(time);
                reflecting.DisplayFinalMessage();
            break;

            case 3:
                Console.Clear();
                ListingActivity listing = new ListingActivity("Listing");
                listing.WelcomeActivityMessage();
                listing.SetThirdMessage();
                time = listing.GetActivityTime();
                listing.DisplayAnimation();
                listing.LoadWords();
                listing.DisplayRandomPrompt(time);
                listing.DisplayFinalMessage();
            break;

            case 4:
                 Console.Clear();
                BurpeesActivity burpee = new BurpeesActivity("Burpees");
                burpee.WelcomeActivityMessage();
                burpee.WelcomeMessage();
                time = burpee.GetActivityTime();
                Console.Clear();
                burpee.DisplayAnimationReady();
                burpee.Burpees(time);
                burpee.DisplayFinalMessage();
            break;

            case 5:
                Console.Write("Good Bye!");
            break;

            default:
                Console.Write("Not a valid option");
            break;
        }
       }


    }

     static int Options(){
        string options = @"
        Menu Options: 
            1. Start breathing activity
            2. Start reflecting activity
            3. Start listing activity
            4. Start stretch activity (burpees)
            5. Quit
        Select a choic from the menu";
        Console.WriteLine(options);
        string answer = Console.ReadLine();
        int num;
        num = int.Parse(answer);
        return num;
       }
}