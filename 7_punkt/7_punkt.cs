using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj kolejno: x, y, r");
        double x, y, r;

        x = inputValue();
        y = inputValue();
        r = inputValue();
        if (r * r > x * x + y * y)
        {
            Console.WriteLine("Podany punkt leży w obrębie koła");
        }
        else
        {
            Console.WriteLine("Podany punkt nie leży w obrębie koła");
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
