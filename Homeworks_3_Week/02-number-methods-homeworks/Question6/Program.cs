namespace Question6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Trigonometrik Sinüs değerini hesaplamak istediğiniz sayıyı giriniz: ");
        string readNumber = Console.ReadLine();
        double useNumber = Convert.ToDouble(readNumber);

        double result = Math.Sin(useNumber);

        System.Console.WriteLine(result);
    }
}
