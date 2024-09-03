namespace Question10;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir ondalıklı sayı giriniz: ");
        string readNumber1 = Console.ReadLine();
        decimal useNumber1 = Convert.ToDecimal(readNumber1);

        System.Console.Write("Basamak sayısını giriniz: ");
        string readNumber2 = Console.ReadLine();
        int useNumber2 = Convert.ToInt32(readNumber2);

        decimal result = Math.Round(useNumber1, useNumber2);
        System.Console.WriteLine(result);
    }
}
