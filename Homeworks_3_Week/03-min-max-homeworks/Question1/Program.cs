using System.Globalization;

namespace Question1;

class Program
{
    static void Main(string[] args)
    {

        //     // WİTH FOR
        // int enBuyuk = int.MinValue;
        // int enKucuk = int.MaxValue;
        // for (int i = 1; i <= 5; i++)
        // {
        //     System.Console.Write("Bir sayı giriniz: ");
        //     int number = int.Parse(Console.ReadLine());
        //     if (number > enBuyuk)
        //     {
        //         enBuyuk = number;
        //     }

        //     if (number < enKucuk)
        //     {
        //         enKucuk = number;
        //     }

        // }

        // System.Console.WriteLine($"En Büyük: {enBuyuk} \nEn Küçük: {enKucuk} ");

        //With WHİLE

        int lowNumber = int.MaxValue;
        int upNumber = int.MinValue;
        int counter = 1;

        do
        {
            System.Console.Write("Bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            if (number > upNumber)
            {
                upNumber = number;
            }
            if (number < lowNumber)
            {
                lowNumber = number;
            }
            counter++;

        } while (counter <= 5);
        System.Console.WriteLine($"En büyük sayı: {upNumber}\nEn Küçük Sayı: {lowNumber}");








    }
}
