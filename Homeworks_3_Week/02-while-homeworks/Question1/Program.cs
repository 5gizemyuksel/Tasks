namespace Question1;

class Program
{
    static void Main(string[] args)
    {
        int sayi;
        int total = 0;

        do
        {
            System.Console.WriteLine("pozitif tam sayı giriniz(çıkış için 0): ");
            sayi = int.Parse(Console.ReadLine());
            if (sayi > 0)
            {
                total += sayi;
            }

        } while (sayi != 0);
        System.Console.WriteLine("toplam: " + total);

    }
}
