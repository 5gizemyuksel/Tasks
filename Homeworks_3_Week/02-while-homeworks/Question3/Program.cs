using System.Globalization;

namespace Question3;

class Program
{
    static void Main(string[] args)
    {
        do
        {

            System.Console.Write("Bir sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                System.Console.WriteLine("Negatif sayılarda çalışmaz.");
                break;
            }


            System.Console.WriteLine(number * number);


        } while (true);












    }
}
