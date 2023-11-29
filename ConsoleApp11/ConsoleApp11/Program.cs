﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Client
{
    public int ClientCode { get; set; }
    public int Year { get; set; }
    public int Month { get; set; }
    public int Hours { get; set; }
}

public class FitnessCenter
{
    public List<Client> Clients { get; set; }

    public void GetLeastHoursMonth(int clientCode)
    {
        var clientData = Clients.Where(c => c.ClientCode == clientCode);

        if (!clientData.Any())
        {
            Console.WriteLine("Нет данных");
            return;
        }

        var years = clientData.GroupBy(c => c.Year);

        foreach (var year in years)
        {
            var leastHoursMonth = year.OrderBy(c => c.Hours).ThenBy(c => c.Month).First();
            Console.WriteLine($"{leastHoursMonth.Hours} {leastHoursMonth.Year} {leastHoursMonth.Month}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        
        List<Client> clients = new List<Client>
        {
            new Client { ClientCode = 1, Year = 2020, Month = 1, Hours = 5 },
            new Client { ClientCode = 1, Year = 2020, Month = 2, Hours = 3 },
            new Client { ClientCode = 1, Year = 2021, Month = 1, Hours = 2 },
            new Client { ClientCode = 2, Year = 2021, Month = 2, Hours = 4 },
            new Client { ClientCode = 1, Year = 2022, Month = 2, Hours = 1 },
            new Client { ClientCode = 2, Year = 2022, Month = 3, Hours = 6 },
        };

        
        FitnessCenter fitnessCenter = new FitnessCenter { Clients = clients };

        
        fitnessCenter.GetLeastHoursMonth(1);
    }
}