public class Reference{
    private String _dataText = "ScriptureText.txt";
    private string _startNumber;
    private string _title;
    private int _section;
    private int _start;
    private int _end;
    public List<Reference> _reference = new List<Reference>();

    public Reference(){}

    public void SubmitFile(){
        //string[] readingFile = System.IO.File.ReadAllLines(_dataText);
        List<string> readingFile = File.ReadAllLines(_dataText).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
        foreach (string i in readingFile){
            string[] newEntry = i.Split(";");
            Reference entries = new Reference();
            entries._startNumber = newEntry[0];
            entries._title = newEntry[1];
            entries._section = int.Parse(newEntry[2]);
            entries._start = int.Parse(newEntry[3]);
            entries._end = int.Parse(newEntry[4]);
            _reference.Add(entries);

        }
    }

    public void DisplayReference(){
        foreach(Reference i in _reference){
            if (i._end.Equals(0)){
                i.FirstShow();
            }
            else{
                i.SecondShow();
            }
        }
    }

    public string DisplayPhrase(Scripture scripture){
        var number = scripture._number;
        var ref1 = _reference[number];
        string text1;
        if (ref1._end.Equals(0)){
            return text1 = $"\n{ref1._title} {ref1._section}: {ref1._start}";
        }
        else{
            return text1 = $"\n{ref1._title} {ref1._section}: {ref1._start}-{ref1._end}";
        }

    }

    public void FirstShow(){
        Console.WriteLine($"\n{_title} {_section}: {_start}");
    }

    public void SecondShow(){
        Console.WriteLine($"\n{_title} {_section}: {_start}-{_end}");
    }
}