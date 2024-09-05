namespace Question5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz(1-4): ");
        char month = Convert.ToChar(Console.ReadLine());

        switch (month)
        {
            case '1':
                System.Console.WriteLine("İlkbahar");
                break;

            case '2':
                System.Console.WriteLine("Yaz");
                break;

            case '3':
                System.Console.WriteLine("Sonbahar");
                break;

            case '4':
                System.Console.WriteLine("Kış");
                break;


            default:
                System.Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                break;
        }
    }
}
