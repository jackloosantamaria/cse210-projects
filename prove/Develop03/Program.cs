using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Console.Clear();
        Reference reference = new Reference();
        reference.SubmitFile();
        Scripture scripture = new Scripture();
        scripture.LoadVerses();
        Words words = new Words();
        reference.DisplayReference();
        string escrit = scripture.GetAleatoryVerse();
        string ref1 = reference.DisplayPhrase(scripture);
        words.GetRenderedText(scripture);
        while(words._hide.Count < words._answer.Length){
            words.Show(ref1);
            words.GetUserNumber();
        }
        words.Show(ref1);
    }
}