namespace Question6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir metin giriniz: ");
        string metin = Console.ReadLine();

        string tersMetin = "";

        int i = metin.Length - 1;


        while (i >= 0)
        {
            tersMetin += metin[i];
            i--;
        }
        System.Console.WriteLine(tersMetin);

    }
}
