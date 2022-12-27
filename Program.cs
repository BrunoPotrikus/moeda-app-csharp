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
        Console.WriteLine(valor.ToString("C", culture));   
    }
}

