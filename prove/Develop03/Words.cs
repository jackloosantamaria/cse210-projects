public class Words{
    private string _letters = "";
    public string[] _answer;
    private string _reference = "";
    public List<int> _hide;


    public Words(){}

    public void GetDisguiseText(){
        var random = new Random();
        var key1 = random.Next(_answer.Length);
        var key2 = random.Next(_answer.Length);
        if (_hide.Contains(key1) || _hide.Contains(key2)){
            GetDisguiseText();
        }
        else{
            _hide.Add(key1);
            _hide.Add(key2);
        }
    }

    public void GetUserNumber(){
        var input = Console.ReadLine();    
        if (input.ToLower() == "quit"){
            Environment.Exit(0);
        }
        if (input == ""){
            GetDisguiseText();
        }
       

       
    }

    public void Show(string text1){
        _reference = text1;
        Console.Clear();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        Console.WriteLine($" {_reference} ");
        for (var i=0; i<_answer.Length; i++){
            var txt = _answer[i];
            int len = txt.Length;
            string underline = new string('_', len);
            if (_hide.Contains(i)){
                Console.Write($" {underline} ");
            }
            else{
                Console.Write($" {txt} ");
            }
        }
    }

   

    public void GetRenderedText(Scripture scripture){
         _letters = scripture._verseText;
        _answer = _letters.Split(" ");
        _hide = new List<int>();
    }

}