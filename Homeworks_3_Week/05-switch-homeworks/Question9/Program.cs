namespace Question9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz(1-5): ");
        char number = Convert.ToChar(Console.ReadLine());

        switch (number)
        {
            case '1':
                System.Console.WriteLine("Birinci");
                break;

            case '2':
                System.Console.WriteLine("İkinci");
                break;

            case '3':
                System.Console.WriteLine("Üçüncü");
                break;

            case '4':
                System.Console.WriteLine("Dördüncü");
                break;

            case '5':
                System.Console.WriteLine("Beşinci");
                break;

            default:
                System.Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
                break;
        }
    }
}
