﻿using System;
using System.Collections.Generic;
using System.Linq;

public class SchoolYear
{
    public int Year { get; set; }
    public List<string> Schools { get; set; }
}

public class Candidate
{
    public int SchoolNumber { get; set; }
    public int AdmissionYear { get; set; }
    public string Surname { get; set; }
}

public class Program
{
    public static void Main()
    {
        
        List<Candidate> candidates = new List<Candidate>
        {
            new Candidate { SchoolNumber = 1, AdmissionYear = 2020, Surname = "Smith" },
            new Candidate { SchoolNumber = 2, AdmissionYear = 2020, Surname = "Johnson" },
            new Candidate { SchoolNumber = 1, AdmissionYear = 2021, Surname = "Williams" },
            new Candidate { SchoolNumber = 3, AdmissionYear = 2021, Surname = "Brown" },
            new Candidate { SchoolNumber = 2, AdmissionYear = 2022, Surname = "Jones" },
            new Candidate { SchoolNumber = 3, AdmissionYear = 2022, Surname = "Miller" },
        };

        
        var candidatesByYear = candidates.GroupBy(c => c.AdmissionYear);

        
        List<SchoolYear> schoolYears = new List<SchoolYear>();

        foreach (var group in candidatesByYear)
        {
            
            schoolYears.Add(new SchoolYear
            {
                Year = group.Key,
                Schools = group.Select(c => c.SchoolNumber.ToString()).Distinct().ToList()
            });
        }

        
        schoolYears = schoolYears.OrderBy(sy => sy.Schools.Count).ThenBy(sy => sy.Year).ToList();

        
        foreach (var sy in schoolYears)
        {
            Console.WriteLine($"{sy.Schools.Count} {sy.Year}");
        }
    }
}