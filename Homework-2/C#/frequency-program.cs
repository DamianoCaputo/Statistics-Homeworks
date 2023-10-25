using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Esempio di dati
        List<int> hardWorkerData = new List<int>
        {
            5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4, 5, 5, 5, 4, 5, 5, 5,
            // Aggiungi i tuoi dati qui
        };

        List<int> ageData = new List<int>
        {
            22, 22, 22, 23, 23, 21, 23, 23, 24, 24, 23, 21, 25, 22, 22, 22, 25,
            // Aggiungi i tuoi dati qui
        };

        List<string> mainInterestsData = new List<string>
        {
            "Cybersecurity", "Cybersecurity", "Vulnerability Research", "Cybersecurity", "Cybersecurity",
            // Aggiungi i tuoi dati qui
        };

        Dictionary<string, int> hardWorkerFrequency = CalculateFrequency(hardWorkerData);
        Dictionary<string, double> hardWorkerRelativeFrequency = CalculateRelativeFrequency(hardWorkerFrequency, hardWorkerData.Count);
        Dictionary<string, double> hardWorkerPercentageFrequency = CalculatePercentageFrequency(hardWorkerRelativeFrequency);

        PrintFrequencyTable(hardWorkerFrequency, hardWorkerRelativeFrequency, hardWorkerPercentageFrequency, "Frequency Distribution (Hard Worker)");

        Dictionary<string, int> ageFrequency = CalculateFrequency(ageData);
        Dictionary<string, double> ageRelativeFrequency = CalculateRelativeFrequency(ageFrequency, ageData.Count);
        Dictionary<string, double> agePercentageFrequency = CalculatePercentageFrequency(ageRelativeFrequency);

        PrintFrequencyTable(ageFrequency, ageRelativeFrequency, agePercentageFrequency, "Frequency Distribution (Age)");

        Dictionary<string, int> mainInterestsFrequency = CalculateFrequency(mainInterestsData);
        Dictionary<string, double> mainInterestsRelativeFrequency = CalculateRelativeFrequency(mainInterestsFrequency, mainInterestsData.Count);
        Dictionary<string, double> mainInterestsPercentageFrequency = CalculatePercentageFrequency(mainInterestsRelativeFrequency);

        PrintFrequencyTable(mainInterestsFrequency, mainInterestsRelativeFrequency, mainInterestsPercentageFrequency, "Frequency Distribution (Main Interests)");
    }

    static Dictionary<string, int> CalculateFrequency(List<int> data)
    {
        var frequency = new Dictionary<string, int>();
        foreach (var item in data)
        {
            var key = item.ToString();
            if (frequency.ContainsKey(key))
                frequency[key]++;
            else
                frequency[key] = 1;
        }
        return frequency;
    }

    static Dictionary<string, double> CalculateRelativeFrequency(Dictionary<string, int> frequency, int totalCount)
    {
        var relativeFrequency = new Dictionary<string, double>();
        foreach (var key in frequency.Keys)
        {
            relativeFrequency[key] = frequency[key] / (double)totalCount;
        }
        return relativeFrequency;
    }

    static Dictionary<string, double> CalculatePercentageFrequency(Dictionary<string, double> relativeFrequency)
    {
        var percentageFrequency = new Dictionary<string, double>();
        foreach (var key in relativeFrequency.Keys)
        {
            percentageFrequency[key] = relativeFrequency[key] * 100.0;
        }
        return percentageFrequency;
    }

    static void PrintFrequencyTable(Dictionary<string, int> frequency, Dictionary<string, double> relativeFrequency, Dictionary<string, double> percentageFrequency, string title)
    {
        Console.WriteLine(title);
        Console.WriteLine("Value\tAbsolute Frequency\tRelative Frequency\tPercentage Frequency");

        var sortedKeys = frequency.Keys.OrderBy(key => double.Parse(key));
        foreach (var key in sortedKeys)
        {
            Console.WriteLine($"{key}\t{frequency[key]}\t{relativeFrequency[key]:P2}\t{percentageFrequency[key]:F2}%");
        }
        Console.WriteLine();
    }
}
