using System;

namespace CalendarApplication;

public class Birthday : Event
{
    public Birthday(string name, string date, string location, string dressCode) : base(name, date, location)
    {
        DressCode = dressCode;
    }
    public string DressCode { get; set; }

    public void GetDressCodeInfo()
    {
        System.Console.WriteLine($"Zorunlu kıyafet rengi: {DressCode}");
    }
}
