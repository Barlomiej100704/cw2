using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczby: a, b, c, d. Na ich podstawie wyliczone będzie x, y z równania x/y=a/b+c/d");
        int a, b, c, d, x, y;

        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        d = (int)inputValue();
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            a = a * d;
            c = c * b;
            b = b * d;
            d = b;
            x = a + c;
            y = b;
            Console.WriteLine("x = " + x);
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
