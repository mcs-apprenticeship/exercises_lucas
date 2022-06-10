public class program
{
    public static void Main()
    {
        Console.WriteLine("Please enter a number:");
        var input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber))
        {
            Console.WriteLine(weekDay(dayNumber));
        }
        else
        {
            Console.WriteLine($"Error: {input} is not a int");
        }
    }

    private static string weekDay(int day)
    {
        return day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid number!"
        };
    }
}