using System.Transactions;

public class Video{

    public string _title;
    public string _author;
    public double _time;
    public List<Comments> _text = new List<Comments>();

    public Video(string title, string author, double time){
        _title = title;
        _author = author;
        _time = time;
    }

    public void ShowComments(Comments comments){
        _text.Add(comments);
    }

    public int Counter(){
        int number;
        number = _text.Count;
        return number;
    }

    public void ShowInfo(){
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length {_time} seconds");
        int counting = Counter();
        Console.WriteLine($"Number of comments: {counting}");
        foreach (Comments comment in _text){
            comment.ShowText();
        }
    }


}