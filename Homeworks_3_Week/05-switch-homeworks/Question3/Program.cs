namespace Question3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1. sayı: ");
        double number1 = double.Parse(Console.ReadLine());


        System.Console.Write("2. Sayı: ");
        double number2 = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Yapmak istediğiniz işlemi seçiniz(+,-,*,/): ");

        char islem = Convert.ToChar(Console.ReadLine());
        double sonuc;

        switch (islem)
        {
            case '+':
                sonuc = number1 + number2;
                System.Console.WriteLine("Sonuç: " + sonuc);
                break;

            case '-':
                sonuc = number1 - number2;
                System.Console.WriteLine("Sonuç: " + sonuc);
                break;

            case '*':
                sonuc = number1 * number2;
                System.Console.WriteLine("Sonuç: " + sonuc);
                break;

            case '/':
                if (number2 != 0)
                {
                    sonuc = number1 / number2;
                    System.Console.WriteLine("Sonuç: " + sonuc);
                }
                else
                {
                    System.Console.WriteLine("0'a bölme işlemi yapılamaz!");
                }

                break;


            default:
                System.Console.WriteLine("Geçersiz işlem girdiniz!");
                break;
        }
    }
}
