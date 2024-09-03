namespace Question3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İşlem yapmak istediğiniz sayıyı giriniz: ");
        string readNumber = Console.ReadLine();

        double useNumber = Convert.ToInt32(readNumber);
        double result = Math.Abs(useNumber);
        System.Console.WriteLine(result);
    }
}
