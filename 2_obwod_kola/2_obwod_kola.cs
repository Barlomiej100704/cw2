using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj pole koła");
        double pole;
        pole = inputValue();
        double promien;
        promien = Math.Sqrt(pole / Math.PI);
        double obwod;
        obwod = 2 * Math.PI * promien;
        Console.WriteLine("Obwód koła to " + obwod);
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
