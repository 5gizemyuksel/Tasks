namespace Question9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Çarpımını bulmak istediğiniz sayıyı giriniz: ");
        double number1 = double.Parse(Console.ReadLine());

        System.Console.Write("Kaçla çarpmak istiyorsanız o sayıyı giriniz: ");
        double number2 = double.Parse(Console.ReadLine());

        double result = number1 * number2;

        if (result > 0)
        {
            System.Console.WriteLine($"{number1} * {number2} = {result}");
        }
        else if (result == 0)
        {
            System.Console.WriteLine($"{number1} * {number2} = {result}");
        }
        else
        {
            System.Console.WriteLine($"{number1} * {number2} = {result}");
        }


    }
}
