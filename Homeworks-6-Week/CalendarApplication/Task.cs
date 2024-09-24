using System;

namespace CalendarApplication;

public class Task : Event
{
    public Task(string name, string date, string location) : base(name, date, location)
    {

    }



    public void MarkAsComplete()
    {
        System.Console.WriteLine($"Mission Completed!");
    }
}
