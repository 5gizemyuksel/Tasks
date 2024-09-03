namespace Question1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir tarih giriniz: ");
        string readDate = Console.ReadLine();

        DateTime date;
        DateTime.TryParse(readDate, out date);
        DayOfWeek day = date.DayOfWeek;
        System.Console.WriteLine(day);

        // yanlış sonuç veriyor
    }
}
