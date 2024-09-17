namespace Question1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        int toplam = 0;

        for (int i = 1; i <= number; i++)
        {
            toplam += i;
        }
        System.Console.WriteLine(toplam);


    }
}
