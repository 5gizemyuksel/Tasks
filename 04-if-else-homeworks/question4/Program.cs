namespace question4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir yıl girin: ");
        int year = int.Parse(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0 && year % 400 == 0)
        {
            System.Console.WriteLine("Bu bir artık yıldır.");
        }
        else
        {
            System.Console.WriteLine("Bu bir artık yıl değildir.");
        }
    }
}
