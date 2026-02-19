using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace Linq_Practice_Project;

public static class Program
{
    public static void Main()
    {
        var ticketData = TicketDB.GetTicketData();

        var openTickets = ticketData.Where(t => t.Status == "Open").ToList();
        var latestFirst = openTickets.OrderByDescending(d => d.Date);
        var ticketSummary = ticketData.Select(s => (Id: s.Id, Title: s.Name, AgeDays: (DateTime.Today - s.Date).Days)).OrderByDescending(x => x.AgeDays).ToList();

        Console.WriteLine("The open tickets are:" );
        Console.WriteLine();

        Console.WriteLine($"OPEN COUNT: {openTickets.Count}");

        foreach (var ticket in openTickets)
        {
            Console.WriteLine($"{ticket.Name}");
        }

        Console.WriteLine();
        Console.WriteLine("TOP 3 LATEST");
        foreach(var ticket in latestFirst.Take(3))
        {
            Console.WriteLine($"#{ticket.Id} {ticket.Date} {ticket.Status} - {ticket.Name}");
        }

        Console.WriteLine();

        Console.WriteLine("SUMMARIES (AGE DESC):");
        foreach (var s in ticketSummary)
        {
            Console.WriteLine($"{s.Id} {s.AgeDays}d - {s.Title}");
        }

        Console.ReadKey();
    }
}