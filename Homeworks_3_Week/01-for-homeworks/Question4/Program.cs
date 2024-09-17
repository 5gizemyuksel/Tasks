namespace Question4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());


        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }


    }
}
