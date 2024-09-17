namespace Question5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Üssünü hesaplamak istediğiniz sayıyı giriniz: ");
        string readNumber1 = Console.ReadLine();
        double useNumber1 = Convert.ToDouble(readNumber1);

        System.Console.Write("Sayının hangi üssünü istiyorsanız o sayıyı giriniz: ");
        string readNumber2 = Console.ReadLine();
        double useNumber2 = Convert.ToDouble(readNumber2);

        double result = Math.Pow(useNumber1, useNumber2);
        System.Console.WriteLine(result);

    }
}
