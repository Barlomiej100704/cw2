using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Wypisz kolejno boki trójkąta");
        int a, b, c;

        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        if (a == b && b == c)
        {
            Console.WriteLine("Trójkąt jest równoboczny");
        }
        else
        {
            Console.WriteLine("Trójkąt nie jest równoboczny");
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
