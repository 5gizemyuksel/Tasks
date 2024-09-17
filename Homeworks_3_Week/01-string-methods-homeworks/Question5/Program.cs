namespace Question5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir cümle giriniz: ");
        string text = Console.ReadLine();

        System.Console.Write("Aranacak kelimeyi giriniz: ");
        string findText = Console.ReadLine();

        System.Console.WriteLine(text.IndexOf(findText));




    }
}
