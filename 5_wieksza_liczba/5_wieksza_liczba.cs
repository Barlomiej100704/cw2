using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj kolejno dwie liczby. Wypisana zostanie większa z nich");
        double a, b;

        a = inputValue();
        b = inputValue();
        Console.Write("Większa jest liczba ");
        if (a < b)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(a);
        }
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
