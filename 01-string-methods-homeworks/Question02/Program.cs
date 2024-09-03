namespace Question02;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cümle giriniz: ");
        string sentence = Console.ReadLine();

        string sentenceLow = sentence.ToLower();
        string sentenceUp = sentence.ToUpper();
        System.Console.Write($"{sentenceLow} \n {sentenceUp}");
    }
}
