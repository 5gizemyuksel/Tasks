namespace Question8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz: ");
        double number = double.Parse(Console.ReadLine());

        if (number % 3 == 0 && number % 5 == 0)
        {
            System.Console.WriteLine("Bu sayı 3 ve 5'e bölünebilir.");
        }
        else
        {
            System.Console.WriteLine("Bu sayı 3 ve 5'e bölünemez.");
        }
    }
}
