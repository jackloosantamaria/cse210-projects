using System;

class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

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
        Console.Clear();
        BurpeesActivity burpee = new BurpeesActivity("Burpees");
        burpee.WelcomeActivityMessage();
        burpee.WelcomeMessage();
        int time = burpee.GetActivityTime();
        Console.Clear();
        burpee.DisplayAnimationReady();
        burpee.Burpees(time);
        burpee.DisplayFinalMessage();

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
    }
}