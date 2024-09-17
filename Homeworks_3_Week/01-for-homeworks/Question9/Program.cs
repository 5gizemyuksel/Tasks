namespace Question9;

class Program
{
    static void Main(string[] args)
    {
        bool isPrime = true;
        Console.Write("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());



        for (int i = 2; i <= number - 1; i++)
        {

            if (number % i == 0)
            {
                isPrime = false;
                break;
            }

        }
        System.Console.WriteLine(isPrime ? "asal" : "asal değil");
    }
}
