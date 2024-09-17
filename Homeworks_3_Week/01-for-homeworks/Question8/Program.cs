namespace Question8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        int toplam = default;
        int sonuc = 0;

        for (int i = number; i >= 1; i--)
        {
            toplam = i * i;
            sonuc = toplam;
            System.Console.WriteLine(i + "*" + i + "= " + sonuc);

        }

    }
}
