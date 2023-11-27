using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation1 World!");
        List<Video> videoInventory = new List<Video>();

        Video videos = new Video("Overcome the World and Find Rest", "Russel M Nelson", 1123);

        Comments comment1 = new Comments("Lesleysole6427", "I love the gospel with all my heart as I do my Heavenly Father");
        Comments comment2 = new Comments("Ezraprice7066", "Such a powerful message. President Nelson is a great, caring man, and truly a prophet of God.");
        Comments comment3 = new Comments("Justinhayward42", "I loved this talk. President Nelson truly is a prophet of God.");

        videos.ShowComments(comment1);
        videos.ShowComments(comment2);
        videos.ShowComments(comment3);

        videoInventory.Add(videos);

        /////////
        
        Video videos2 = new Video("Fear Not: Believe Only!", "Jeffery R Holland", 811);

        Comments comment4 = new Comments("Snookyjabay872", "We can always share the Good News as we deepen our understanding unto the Gospel of Jesus Christ.");
        Comments comment5 = new Comments("Barber684danz4", "Embracing the bounty we have already received from the giver of every good gift.");
        Comments comment6 = new Comments("Mow4607", "Not just the youth need to hear this.");

        videos2.ShowComments(comment4);
        videos2.ShowComments(comment5);
        videos2.ShowComments(comment6);

        videoInventory.Add(videos2);

        ////////
        
        Video videos3 = new Video("Be not Afraid, Only Believe", "Dieter F Uchtdorf", 1170);

        Comments comment7 = new Comments("Fishurmn0344", "I needed this today. So grateful for his insight on faith.");
        Comments comment8 = new Comments("Myamazinganimals1515", "This channel actually helps me get through the day thank you.");
        Comments comment9 = new Comments("TanookiToadTeam", "Such an amazing talk! Definitely needed this one today!:)");

        videos3.ShowComments(comment7);
        videos3.ShowComments(comment8);
        videos3.ShowComments(comment9);

        videoInventory.Add(videos3);

        foreach (Video video in videoInventory){
            video.ShowInfo();
            Console.WriteLine("");
        }


    }
}