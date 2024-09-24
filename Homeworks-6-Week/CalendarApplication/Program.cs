namespace CalendarApplication;

class Program
{
    static void Main(string[] args)
    {
        Event @event = new Event("Nişan", "17,4,2026", "Beykoz");

        @event.DisplayInfo();

        System.Console.WriteLine("****************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        Meeting meeting = new Meeting("Yazılım Topluluğu", "29,9,2024", "Maslak");

        meeting.GetDateInformation();
        System.Console.WriteLine("****************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        Birthday birthday = new Birthday("Didem's Birthday", "2024,11,5", "Üsküdar", "Beyaz");
        birthday.GetDressCodeInfo();
        System.Console.WriteLine("****************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        Task task = new Task("Didem's Birthday", "2024, 11, 5", "Üsküdar");
        task.MarkAsComplete();
    }
}
