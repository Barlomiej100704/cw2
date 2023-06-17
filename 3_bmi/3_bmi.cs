﻿using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double waga, wzrost;
        Console.WriteLine("Podaj wage");
        waga = inputValue();
        Console.WriteLine("Podaj wzrost");
        wzrost = inputValue();
        double bmi;
        bmi = waga / Math.Pow(wzrost, 2) * 10000;
        Console.WriteLine(bmi);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
