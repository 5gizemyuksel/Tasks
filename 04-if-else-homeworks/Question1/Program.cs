namespace Question1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("bir sayı giriniz: ");
        string readNumber = Console.ReadLine();

        int useNumber = Convert.ToInt32(readNumber);

        if (useNumber > 0)
        {
            System.Console.WriteLine("Pozitif sayı");
        }
        else if (useNumber == 0)
        {
            System.Console.WriteLine("0");
        }
        else
        {
            System.Console.WriteLine("Negatif sayı");
        }

        System.Console.WriteLine("uygulama sona erdi!");








    }
}
