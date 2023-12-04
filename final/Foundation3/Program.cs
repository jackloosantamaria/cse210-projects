using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation3 World!");

        Address address = new Address("Terranova Avenue", "Ernesto Cordoba Campos", "PA", "Republic of Panama");

        Lecture lecture = new Lecture("Public Health", "Conference on Occupational Health and Safety", "December 15, 2023", "7:30 pm", address, "Francisco Ortiz", 200);
        Console.WriteLine("\nEvent Number: 1");
        Console.WriteLine("" + lecture.CreateEvent() + "\n");
        Console.WriteLine("" + lecture.LectureDetail() + "\n");
        Console.WriteLine("" + lecture.CreateEventLecture() + "\n");

        ///////////////// 
        
        Address address2 = new Address("Elvira Mendez Street", "Bella Vista", "PA", "Republic of Panama");

        Receptions receptions = new Receptions("Devotional for Adults", "Face to Face with Elder Gary E Stevenson", "May 15th, 2023", "5 pm", address2, "panamadevotional@churchofjesuschrist.org");

        Console.WriteLine("\nEvent Number: 2");
        Console.WriteLine("" + receptions.CreateEvent() + "");
        Console.WriteLine("" + receptions.ReceiptionDetail()+ "");
        Console.WriteLine("" + receptions.CreateEventReception());

        /////////////////
        
        Address address3 = new Address("3172 Rufina Alfaro St", "Cardenas", "PA", "Republic of Panama");

        Gathering gathering = new Gathering("Historic Sites Festival", "Celebration of the 65 Years of the First Chapel in Panama", "September 10th, 2023", "10 am", address3, "sunny");

        Console.WriteLine("\nEvent Number: 3");
        Console.WriteLine("" + gathering.CreateEvent() + "");
        Console.WriteLine("" + gathering.GatheringDetail() + "");
        Console.WriteLine("" + gathering.CreateEventGathering() + "");
        


    }

}