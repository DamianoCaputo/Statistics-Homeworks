using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Esempio di dati
        List<string> qualitativeData = new List<string> { /* Inserisci i tuoi dati qualitativi qui */ };
        List<int> discreteQuantitativeData = new List<int> { /* Inserisci i tuoi dati quantitativi discreti qui */ };
        List<double> continuousQuantitativeData = new List<double> { /* Inserisci i tuoi dati quantitativi continui qui */ };

        // Calcola la distribuzione di frequenza assoluta
        var qualitativeFrequency = CalculateFrequency(qualitativeData);
        var discreteQuantitativeFrequency = CalculateFrequency(discreteQuantitativeData);
        var continuousQuantitativeFrequency = CalculateFrequency(continuousQuantitativeData);

        // Visualizza la distribuzione di frequenza assoluta
        Console.WriteLine("Distribuzione di Frequenza Assoluta (Qualitativa):");
        PrintFrequency(qualitativeFrequency);

        Console.WriteLine("Distribuzione di Frequenza Assoluta (Quantitativa Discreta):");
        PrintFrequency(discreteQuantitativeFrequency);

        Console.WriteLine("Distribuzione di Frequenza Assoluta (Quantitativa Continua):");
        PrintFrequency(continuousQuantitativeFrequency);

        // Puoi ora calcolare e visualizzare la distribuzione congiunta tra due variabili
        // Supponiamo che vogliamo calcolare la distribuzione congiunta tra la variabile qualitativa e quella discreta
        var jointDistribution = CalculateJointDistribution(qualitativeData, discreteQuantitativeData);
        Console.WriteLine("Distribuzione Congiunta tra Qualitativa e Quantitativa Discreta:");
        PrintFrequency(jointDistribution);
    }

    static Dictionary<T, int> CalculateFrequency<T>(List<T> data)
    {
        var frequency = new Dictionary<T, int>();
        foreach (var item in data)
        {
            if (frequency.ContainsKey(item))
            {
                frequency[item]++;
            }
            else
            {
                frequency[item] = 1;
            }
        }
        return frequency;
    }

    static Dictionary<Tuple<T, U>, int> CalculateJointDistribution<T, U>(List<T> data1, List<U> data2)
    {
        var jointDistribution = new Dictionary<Tuple<T, U>, int>();
        for (int i = 0; i < data1.Count; i++)
        {
            var key = new Tuple<T, U>(data1[i], data2[i]);
            if (jointDistribution.ContainsKey(key))
            {
                jointDistribution[key]++;
            }
            else
            {
                jointDistribution[key] = 1;
            }
        }
        return jointDistribution;
    }

    static void PrintFrequency<T>(Dictionary<T, int> frequency)
    {
        foreach (var item in frequency)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
