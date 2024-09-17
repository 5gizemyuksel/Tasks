namespace Question4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        int toplam = 0;

        while (number > 0)
        {
            int rakam = number % 10;

            toplam += rakam;

            number /= 10;
        }
        System.Console.WriteLine(toplam);
    }
}
