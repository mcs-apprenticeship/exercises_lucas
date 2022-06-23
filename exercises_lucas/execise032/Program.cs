using System.Globalization;
public class Program
{
    public static void Main()
    {
        Duration duration = new(0);
        Console.WriteLine("Enter a startdate(dd/MM/yyyy):");

        Deadline deadLine = new();
        deadLine.SetStartDate(DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture));

        Console.WriteLine("Enter Hours:");
        double hours = duration.ConvertToSeconds(Double.Parse(Console.ReadLine(), duration.getCorrectFromat("h"));
        Console.WriteLine("Enter Minutes:");

        Console.WriteLine("Enter Seconds:");

        duration.DurationInSeconds = duration.ConvertToSeconds(time, duration.getCorrectFromat(Console.ReadLine()));

        Console.Clear();

        Console.WriteLine($"Deadline set to: {deadLine.StartDate.AddSeconds(duration.DurationInSeconds)}");

        do
        {
            Console.WriteLine("Deadline not passed yet.");
        } while (deadLine.DeadLinePassed(duration.DurationInSeconds));
        Console.WriteLine
    }
}

public class Duration
{
    public double DurationInSeconds { get; set; }

    public enum DurationUnits
    {
        s,
        m,
        h,
    }

    public double ConvertToSeconds(double duration, DurationUnits units)
    {
        double result = units switch
        {
            DurationUnits.s => duration,
            DurationUnits.m => duration * 60,
            DurationUnits.h => duration * 3600,
            _ => 0,
        };
        return result;
    }

    public DurationUnits getCorrectFromat(string format)
    {
        var unit = format switch
        {
            "s" => DurationUnits.s,
            "m" => DurationUnits.m,
            "h" => DurationUnits.h,
        };
        return unit;
    }

    public void addSeconds(double amount)
    {
        DurationInSeconds = DurationInSeconds + amount;
    }

    public Duration(double durationInSeconds)
    {
        DurationInSeconds = durationInSeconds;
    }
}

public class Deadline 
{
    public DateTime StartDate { get; set; }

    public void SetStartDate(DateTime date)
    {
        StartDate = date;
    }

    public bool DeadLinePassed(double duration)
    {
        return StartDate.AddSeconds(duration) >= DateTime.Now ? true : false;
    }
}
