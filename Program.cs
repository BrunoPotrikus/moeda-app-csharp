using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        var valor = 10.25;

        var culture = CultureInfo.CreateSpecificCulture("pt-BR");

        // "C" coloca o valor com padrão de moeda, ex: R$, $. 
        Console.WriteLine($"Valor: {valor.ToString("C", culture)}"); 
        
        Console.WriteLine($"Arredondando com Math.Round(): {Math.Round(valor).ToString(culture)}");
        Console.WriteLine($"Arredondando com Math.Ceiling(): {Math.Ceiling(valor).ToString(culture)}");
        Console.WriteLine($"Arredondando com Math.Floor(): {Math.Floor(valor).ToString(culture)}");
    }
}

