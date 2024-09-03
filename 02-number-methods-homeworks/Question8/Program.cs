namespace Question8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Logaritmasını hesaplamak istediğiniz sayıyı giriniz: ");

        string readNumber = Console.ReadLine();
        double useNumber = Convert.ToDouble(readNumber);

        double result = Math.Log(useNumber);
        System.Console.WriteLine(result);
    }
}
