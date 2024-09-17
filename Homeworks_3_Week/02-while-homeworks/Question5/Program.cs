namespace Question5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        int ters = 0;

        while (number > 0)
        {
            int basamak = number % 10;

            ters = ters * 10 + basamak;

            number /= 10;
        }
        System.Console.WriteLine(ters);
    }
}
