namespace Question7;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen bir üst sınır giriniz: ");
        int up = int.Parse(Console.ReadLine());


        while (number <= up)
        {
            System.Console.WriteLine(number);

            number *= 2;
        }
        System.Console.WriteLine(number);




    }
}
