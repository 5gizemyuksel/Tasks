namespace Question4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen bir harf giriniz: ");
        char harf = Convert.ToChar(Console.ReadLine().ToLower());


        switch (harf)
        {
            case 'a':
            case 'e':
            case 'ı':
            case 'i':
            case 'o':
            case 'ö':
            case 'u':
            case 'ü':

                System.Console.WriteLine("Girilen harf sesli harftir");

                break;

            default:
                System.Console.WriteLine("Girilen harf sesli harf değildir!");
                break;
        }
    }
}
