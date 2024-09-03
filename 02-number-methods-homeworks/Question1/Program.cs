using System.Xml.XPath;

namespace Question1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İşlem yapılacak sayıyı giriniz: ");
        string readNumber = Console.ReadLine();
        double number = Convert.ToDouble(readNumber);

        double result = Math.Round(number);
        System.Console.WriteLine(result);


    }
}
