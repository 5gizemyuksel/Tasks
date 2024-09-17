using System.Runtime.InteropServices;

namespace Question5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1'den 100'e kadar olan asal sayılar: ");
        for (int num = 2; num <= 100; num++)
        {
            bool asal = true;
            for (int i = 2; i < num - 1; i++)// num-1 yerine math.sqrt da kullanabilirsin. 
            {
                if (num % i == 0)
                {
                    asal = false;
                    break;
                }

            }
            if (asal)
            {
                System.Console.WriteLine(num);
            }
        }

    }
}



