namespace Question10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir işlem karakteri giriniz(+,-,*,/,%): ");
        char operation = Convert.ToChar(Console.ReadLine());

        switch (operation)
        {
            case '+':
                System.Console.WriteLine("Toplama İşlemi");
                break;

            case '-':
                System.Console.WriteLine("Çıkarma İşlemi");
                break;

            case '*':
                System.Console.WriteLine("Çarpma İşlemi");
                break;

            case '/':
                System.Console.WriteLine("Bölme İşlemi");
                break;

            case '%':
                System.Console.WriteLine("Modüler Aritmetik İşlemi ");
                break;

            default:
                System.Console.WriteLine("Lütfen geçerli bir karakter giriniz.");
                break;
        }
    }
}
