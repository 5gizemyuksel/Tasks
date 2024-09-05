namespace Question7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen 1-5 arası bir sayı giriniz: ");
        char number = Convert.ToChar(Console.ReadLine());

        switch (number)
        {
            case '1':
                System.Console.WriteLine("1 Kr.");
                break;

            case '2':
                System.Console.WriteLine("5 Kr. ");
                break;

            case '3':
                System.Console.WriteLine("10 Kr.");
                break;

            case '4':
                System.Console.WriteLine("25 Kr.");
                break;

            case '5':
                System.Console.WriteLine("50 Kr.");
                break;

            default:
                System.Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                break;
        }
    }
}
