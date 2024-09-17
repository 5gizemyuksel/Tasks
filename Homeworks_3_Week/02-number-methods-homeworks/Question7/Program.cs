namespace Question7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir açıyı derece cinsinden giriniz: ");
        string readNumber = Console.ReadLine();

        double useNumber = Convert.ToDouble(readNumber);

        double result = useNumber * (Math.PI / 180);
        System.Console.WriteLine(result);


    }
}
