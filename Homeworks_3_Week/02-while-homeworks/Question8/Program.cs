namespace Question8;

class Program
{
    static void Main(string[] args)
    {

        int number;

        int toplam = 0;
        int counter = 0;
        double ortalama = 0;

        do
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            number = int.Parse(Console.ReadLine());



            toplam += number;

            counter++;

            ortalama = toplam / counter;

            System.Console.WriteLine("Sayıların toplamı: " + toplam);
            System.Console.WriteLine("Girilen sayı adeti: " + counter);
            System.Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);

        } while (number <= 100);



    }
}
