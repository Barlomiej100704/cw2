using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj 2 liczby");
        double a, b, typOperacji;

        a = inputValue();
        b = inputValue();
        Console.WriteLine("Podaj typ działania: dodawanie - 1 , odejmowanie - 2, mnożenie - 3, dzielenie - 4");
        typOperacji = inputValue();
        Console.Write("Wynik wynosi: ");
        if (typOperacji == 1)
        {
            Console.WriteLine(a + b);
        }
        else
        {
            if (typOperacji == 2)
            {
                Console.WriteLine(a - b);
            }
            else
            {
                if (typOperacji == 3)
                {
                    Console.WriteLine(a * b);
                }
                else
                {
                    if (typOperacji == 4)
                    {
                        if (b == 0)
                        {
                            Console.Write(a);
                            Console.WriteLine("/" + b);
                        }
                        else
                        {
                            Console.WriteLine(a / b);
                        }
                    }
                    else
                    {
                        Console.WriteLine("podana wartość jest niepoprawna");
                    }
                }
            }
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
