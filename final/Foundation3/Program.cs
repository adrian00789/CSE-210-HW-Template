using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Event> eventList = new List<Event>();

        Address addr1 = new Address("123 Park Street", "New York", "NY", "USA");
        eventList.Add(new Lecture("Lecture1", "Description1", DateTime.Now, "10:00AM", addr1,
        "John Doe", 50));

        Address addr2 = new Address("456 Palm Street", "Toronto", "ON", "Canada");
        eventList.Add(new Reception("Reception1", "Description2", DateTime.Now.AddDays(5),
        "09:00PM", addr2, "rsvp@eventmail.com"));

        Address addr3 = new Address("789 Beach Street", "Miami", "FL", "USA");
        eventList.Add(new OutdoorGathering("Gathering1", "Description3", DateTime.Now.AddDays(7),
        "12:00PM", addr3, "Sunny"));

        foreach (var item in eventList)
        {
            Console.WriteLine("Standard Details:\n" + item.GetStandardDetails() + "\n");
            Console.WriteLine("Full Details:\n" + item.GetFullDetails() + "\n");
            Console.WriteLine("Short Description:\n" + item.GetShortDescription() + "\n");
        }
    }
}