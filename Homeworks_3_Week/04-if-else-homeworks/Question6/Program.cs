using System.Formats.Asn1;

namespace Question6;

class Program
{
    static void Main(string[] args)
    {

        System.Console.Write("Bir not giriniz(0-100): ");
        byte score = byte.Parse(Console.ReadLine());


        if (score >= 0 && score <= 39)
        {
            System.Console.WriteLine("FF");
        }
        else if (score > 39 && score <= 49)
        {
            System.Console.WriteLine("FD");
        }
        else if (score > 49 && score <= 54)
        {
            System.Console.WriteLine("DD");
        }
        else if (score > 54 && score <= 59)
        {
            System.Console.WriteLine("DC");
        }
        else if (score > 59 && score <= 69)
        {
            System.Console.WriteLine("CC");
        }
        else if (score > 69 && score <= 79)
        {
            System.Console.WriteLine("CB");
        }
        else if (score > 84 && score <= 89)
        {
            System.Console.WriteLine("BA");
        }
        else if (score > 89 && score <= 100)
        {
            System.Console.WriteLine("AA");
        }
        else
        {
            System.Console.WriteLine("Lütfen 0-100 arası bir değer giriniz.");
        }







    }
}
