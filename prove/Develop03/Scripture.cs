using System.Text;
using System.IO;
using System.Diagnostics.Contracts;

public class Scripture{
    private string _dataText = "ScriptureText.txt";
    private string _startNumber;
    private string _data;
    private List<Scripture> _text = new List<Scripture> ();
    public int _number;
    public string _verseText;

    public Scripture (){

    }

    public void LoadVerses(){
       // string[] readingFile = System.IO.File.ReadAllLines(_dataText);
       List<string> readingFile = File.ReadAllLines(_dataText).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

        foreach (string i in readingFile){
            string [] newEntry = i.Split(";");
            Scripture entries = new Scripture();
            entries._startNumber = newEntry[0];
            entries._data = newEntry[5];
            _text.Add(entries);
        }

    }

   

    public void HideWords(){}

    public void GetRenderedText(){}

    public void IsCompletelyHidden(){}

    public string GetAleatoryVerse(){
        _number = AleatoryNumber();
        return _verseText = _text[_number]._data;
    }

    public int AleatoryNumber(){
        var random = new Random();
        _number = random.Next(_text.Count);
        return _number;
    }

}