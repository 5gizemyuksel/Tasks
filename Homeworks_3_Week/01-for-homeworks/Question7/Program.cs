namespace Question7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        int toplam = 0;
        int sonuc = default;

        for (int i = 2; i <= number; i += 2)
        {
            sonuc = toplam += i;

        }
        System.Console.WriteLine(sonuc);
    }
}
