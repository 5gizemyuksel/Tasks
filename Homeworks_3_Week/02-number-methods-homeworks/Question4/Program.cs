namespace Question4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İşlem yapmak istediğiniz sayıyı giriniz: ");
        string readNumber = Console.ReadLine();
        double useNumber = Convert.ToDouble(readNumber);

        double result = Math.Sqrt(useNumber);
        System.Console.WriteLine(result);
    }
}
