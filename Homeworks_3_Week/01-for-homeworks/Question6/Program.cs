namespace Question6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen 10'dan büyük bir sayı griniz: ");
        int number = int.Parse(Console.ReadLine());



        for (int i = 1; i <= number; i++)
        {

            int kare = i * i;
            System.Console.WriteLine(i + "^2 =" + kare);

        }

    }
}
