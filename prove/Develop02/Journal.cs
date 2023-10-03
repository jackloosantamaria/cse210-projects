using System.Text;
using System.IO;

public class Journal{

    public List<Entry> _textFile = new List<Entry>();

    private string _fileEntry;

    public Journal(){}

    public void Display(){

        foreach (Entry entry in _textFile){

            entry.Display();

        }

    }

    public void NewTextFile(){

        Console.Write("Please provide file name: ");
        _fileEntry = Console.ReadLine();

        if (!File.Exists(_fileEntry)){

            File.Create(_fileEntry);
            Console.Write("File created");
            SaveTextFile(_fileEntry);

        }

        else{
            Console.Write($"{_fileEntry} File already created.");
            AddTextFile(_fileEntry);
        }

    }

    public void SaveTextFile(string _fileEntry){
        using (StreamWriter finalFile = new StreamWriter(_fileEntry)){
            foreach (Entry entry in _textFile){
                finalFile.WriteLine($"{entry._choiceNumber}; {entry._dateTime}; {entry._userPrompt}; {entry._userEntry}");
            }
        }
    }

    public void AddTextFile(string _fileEntry){
        using (StreamWriter finalFile = new StreamWriter(_fileEntry, append: true)){
            foreach (Entry entry in _textFile){
                finalFile.WriteLine($"{entry._choiceNumber}; {entry._dateTime}; {entry._userPrompt}; {entry._userEntry}");
            }
        }
    }

    public void LoadTextFile(){
        Console.WriteLine("Please provide file name: ");
        string _fileEntry = Console.ReadLine();

        if (File.Exists(_fileEntry)){
            //string[] currentText = File.ReadAllLines(_fileEntry,Encoding.UTF8);
            string[] currentText = System.IO.File.ReadAllLines(_fileEntry);
            foreach (string i in currentText){
                string[] newData = i.Split(";");
                Entry entry = new Entry();
                entry._choiceNumber = newData[0];
                entry._dateTime = newData[1];
                entry._userPrompt = newData[2];
                entry._userEntry = newData[3];

                _textFile.Add(entry);
            }
        }
    }


}