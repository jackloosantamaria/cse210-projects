using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.Json.Serialization;
using System.Text.Json;

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

        Console.Write("Please provide TXT file name: ");
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

    public void NewFileJSON(){
        Console.WriteLine("\nPlease provide JSON File: ");
        string newDocument = Console.ReadLine();
        List<JsonData> _document = new List<JsonData>();
        foreach (Entry entry in _textFile){
            _document.Add(new JsonData(){ 
            Time = entry._dateTime,
            Prompt = entry._userPrompt,
            Answer = entry._userEntry
        });
        }

        string newJson = JsonSerializer.Serialize(_document);
        File.WriteAllText(newDocument, newJson);
    }


}