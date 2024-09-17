namespace Question6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir npt giriniz(A,B,C,D,F): ");
        char point = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (point)
        {
            case 'A':
                System.Console.WriteLine("Geçti");
                break;

            case 'B':
                System.Console.WriteLine("Geçti");
                break;

            case 'C':
                System.Console.WriteLine("Geçti");
                break;

            case 'D':
                System.Console.WriteLine("KALDI");
                break;

            case 'F':
                System.Console.WriteLine("KALDI");
                break;
            default:
                System.Console.WriteLine("Lütfen geçerli bir karakter giriniz!");
                break;
        }

    }
}
