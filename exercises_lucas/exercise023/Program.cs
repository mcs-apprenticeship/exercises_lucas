using System;

public class programm
{
    

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Converter");
            Console.WriteLine("=================================");
            Console.WriteLine("1. mm         -> inch");
            Console.WriteLine("2. inch       -> mm");
            Console.WriteLine("3. celsius    -> fahrenheit");
            Console.WriteLine("4. fahrenheit -> celsius");
            Console.WriteLine("5. km         -> miles");
            Console.WriteLine("6. miles      -> km");
            Console.WriteLine("");
            Console.WriteLine("Option: ");
            string optionSelected = Console.ReadLine();
            Console.WriteLine("=================================");

            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("=================================");
            Console.WriteLine("Value: ");

            double value = double.Parse(Console.ReadLine());
            Console.WriteLine("=================================");

            Console.WriteLine("");
            Console.WriteLine($"{converter(value, optionSelected)}");
            Console.WriteLine("=================================");

            Thread.Sleep(3500);
            Console.Clear();
        }
    }

    private static double converter(double value, string optionselected)
    {
        double result = optionselected switch
        {
            "1" => Math.Round(value/25.4, 2),
            "2" => Math.Round(value*25.4, 2), 
            "3" => Math.Round((value + 32 ) *1.8, 2),
            "4" => Math.Round((value - 32 ) /1.8,2),
            "5" => Math.Round(value*0.62137, 2),
            "6" => Math.Round(value/0.62137, 2),
        };
        return result;
    }
}

