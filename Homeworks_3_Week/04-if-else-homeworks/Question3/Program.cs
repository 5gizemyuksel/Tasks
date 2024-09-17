namespace Question3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("bir karakter giriniz: ");
        char key = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (key == 'a' || key == 'e' || key == 'ı' || key == 'i' || key == 'u' || key == 'ü' || key == 'o' || key == 'ö' || key == 'A' || key == 'E' || key == 'I' || key == 'İ' || key == 'U' || key == 'Ü' || key == 'O' || key == 'Ö')
        {
            System.Console.WriteLine($"{key} bir sesli harftir.");
        }
        else
        {
            System.Console.WriteLine($"{key} sesli harf değildir.");
        }
    }
}
