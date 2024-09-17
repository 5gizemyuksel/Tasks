namespace Question7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1. sayıyı giriniz: ");
        byte number1 = byte.Parse(Console.ReadLine());

        Console.Write("2. sayıyı giriniz: ");
        byte number2 = byte.Parse(Console.ReadLine());

        Console.Write("3. sayıyı giriniz: ");
        byte number3 = byte.Parse(Console.ReadLine());

        byte[] numbers = new byte[] { number1, number2, number3 };

        if (number1 > number2 && number1 > number3)
        {
            System.Console.WriteLine($"{number1} en büyük sayıdır.");
        }
        else if (number1 > number2 && number1 < number3)
        {
            System.Console.WriteLine($"{number3} en büyük sayıdır.");
        }
        else if (number1 > number3 && number1 < number2)
        {
            System.Console.WriteLine($"{number2} en büyük sayıdır.");
        }
        else if (number1 < number2 && number1 < number3 && number2 < number3)
        {
            System.Console.WriteLine($"{number3} büyüktür");
        }
        else if (number1 < number2 && number1 < number3 && number2 > number3)
        {
            System.Console.WriteLine($"{number2} büyüktür");
        }
        else
        {
            System.Console.WriteLine("kodda hata var");
        }






    }
}
