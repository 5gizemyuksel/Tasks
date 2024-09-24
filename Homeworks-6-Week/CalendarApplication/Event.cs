using System;

namespace CalendarApplication;

public class Event
{
    public Event(string name, string date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public string Name { get; set; }
    public string Date { get; set; }
    public string Location { get; set; }
 
    public void DisplayInfo()
    {
        System.Console.WriteLine($"Etkinlik adı: {Name}\nEtkinlik Tarihi: {Date}\nEtkinlik Konumu: {Location}");
    }

}
