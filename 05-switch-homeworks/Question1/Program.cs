namespace Question1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen Haftanın kaçıncı gününü öğrenmek istediğinizi giriniz(1-7):");
        int dayNumber = int.Parse(Console.ReadLine());
        string day = "";

        switch (dayNumber)
        {
            case <= 1:
                day = "pazartesi";

                break;

            case <= 2:
                day = "salı";
                break;

            case <= 3:
                day = "çarşamba";
                break;

            case <= 4:
                day = "perşembe";
                break;

            case <= 5:
                day = "cuma";
                break;

            case <= 6:
                day = "cumartesi";
                break;

            case <= 7:
                day = "pazar";
                break;


            default:
                System.Console.Write("Lütfen haftanın kaçıncı gününü öğrenmek istiyorsanız onu giriniz(1-7): ");
                break;
        }

        if (dayNumber > 0 && dayNumber <= 7)
        {
            System.Console.WriteLine(day);
        }
    }
}
