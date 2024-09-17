namespace Question2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Yılın kaçıncı ayını öğrenmek istediğinizi giriniz: ");
        int month = int.Parse(Console.ReadLine());
        string monthNumber = "";

        switch (month)
        {
            case <= 1:
                monthNumber = "Ocak";
                break;

            case <= 2:
                monthNumber = "Şubat";
                break;

            case <= 3:
                monthNumber = "Mart";
                break;

            case <= 4:
                monthNumber = "Nisan";
                break;

            case <= 5:
                monthNumber = "Mayıs";
                break;

            case <= 6:
                monthNumber = "Haziran";
                break;

            case <= 7:
                monthNumber = "Temmuz";
                break;

            case <= 8:
                monthNumber = "Ağustos";
                break;

            case <= 9:
                monthNumber = "Eylül";
                break;

            case <= 10:
                monthNumber = "Ekim";
                break;

            case <= 11:
                monthNumber = "Kasım";
                break;

            case <= 12:
                monthNumber = "Aralık";
                break;


            default:

                break;
        }
        if (month > 0 && month <= 12)
        {
            System.Console.WriteLine(monthNumber);
        }
        else
        {
            System.Console.WriteLine("Lütfen geçerli bir sayı giriniz!");
        }
    }
}
