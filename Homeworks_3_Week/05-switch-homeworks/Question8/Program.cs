namespace Question8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz(0-6): ");
        char number = Convert.ToChar(Console.ReadLine());

        switch (number)
        {
            case '0':
                System.Console.WriteLine("Nokta");
                break;

            case '1':
                System.Console.WriteLine("Çizgi");
                break;

            case '2':
                System.Console.WriteLine("Açı");
                break;

            case '3':
                System.Console.WriteLine("Üçgen");
                break;

            case '4':
                System.Console.WriteLine("Kare");
                break;

            case '5':
                System.Console.WriteLine("Beşgen");
                break;

            case '6':
                System.Console.WriteLine("Altıgen");
                break;

            default:
                System.Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                break;
        }
    }
}
