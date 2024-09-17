namespace Question2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        // int küp = 3;
        // int sonuc;
        // int toplam = 0;

        // for (int i = 1; i <= number; i++)
        // {
        //     sonuc = küp *= i;
        //     toplam += sonuc;

        //     System.Console.WriteLine($"{i}*3 = {toplam}");

        // }

        for (int i = 1; i <= number; i++)
        {
            int küp = i * i * i;
            System.Console.WriteLine(i + "^3= " + küp);
        }


    }
}
