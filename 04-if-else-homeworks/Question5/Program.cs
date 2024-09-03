namespace Question5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı giriniz: ");
        int number1 = int.Parse(Console.ReadLine());

        System.Console.Write("İkinci sayıyı giriniz: ");
        int number2 = int.Parse(Console.ReadLine());

        System.Console.Write("Üçüncü sayıyı giriniz: ");
        int number3 = int.Parse(Console.ReadLine());

        if (number1 + number2 + number3 == 180 && number1 != 0 && number2 != 0 && number3 != 00)
        {
            System.Console.Write("Bu değerler bir üçgen oluşturur.");
        }
        else
        {
            System.Console.WriteLine("Bu değerler bir üçgen oluşturmaz.");
        }
    }
}
