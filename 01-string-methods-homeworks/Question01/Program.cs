namespace Question01;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cümle giriniz: ");
        string sentence = Console.ReadLine();

        string[] word = sentence.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int wordLength = word.Length;
        System.Console.WriteLine("Girilen cümledeki kelimesi sayısı: " + wordLength);
    }
}
