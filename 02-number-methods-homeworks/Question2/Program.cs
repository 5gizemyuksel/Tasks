namespace Question2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı giriniz: ");
        string readNumber1 = Console.ReadLine();
        double useNumber1 = Convert.ToDouble(readNumber1);

        System.Console.Write("İkinci sayıyı giriniz: ");
        string readNumber2 = Console.ReadLine();
        double useNumber2 = Convert.ToDouble(readNumber2);

        double result = Math.Max(useNumber1, useNumber2);
        System.Console.Write(result);














    }
}
