namespace Question3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());


        for (int i = 1; i <= number; i++)
        {


            if (number % i == 0)
            {
                System.Console.WriteLine(i);
            }


        }

    }
}
