using System;

class Program
{
    static void Main(string[] args){
    //int[] numbers = {1,2,3,4,5};
    int _num = 0;
    Journal j = new Journal();
    Prompts p = new Prompts();
        while(_num != 5) {
            _num = Options();
            switch (_num){
                case 1:
                    string timeInfo = ShowDateTime();
                    string prompt = p.ShowPrompt();
                    Entry entry = new Entry();
                    entry._dateTime = timeInfo;
                    entry._userPrompt = prompt;
                    Console.Write($"{prompt}");
                    string newEntry = Console.ReadLine();
                    entry._userEntry = newEntry;
                    j._textFile.Add(entry);
                break;
                            

                case 2:
                    j.Display();
                break;

                case 3:
                    j.LoadTextFile();
                break;

                case 4:
                    j.NewTextFile();
                    j.NewFileJSON();
                break;

                case 5:
                    Console.Write("Bye!");
                break;

            

                default:
                    Console.Write("Not a valid option");
                break;
                }
        }   
        

       

    }

    static string ShowDateTime(){
        DateTime _currentTime = DateTime.Now;
        string time = _currentTime.ToString("f");
        return time;
    }

    static int Options(){

        string options = @" Welcome to the Journal Program!
        Please select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do? ";
        Console.WriteLine(options);
        string answer = Console.ReadLine();
        int num;
        num = int.Parse(answer);
        return num;
    }

   
    
    


}