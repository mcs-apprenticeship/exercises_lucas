public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter a value:");

        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}", string.Join(", ", returnFibonacciRecursive(value)));
    }

    public static List<int> returnFibonacciLoop(int value)
    {
        List<int> fibonacci = new();

        fibonacci.Add(0);
        fibonacci.Add(1);
        int index = 2;

        while (fibonacci[index-2] + fibonacci[index-1] < value)
        {
            fibonacci.Add(fibonacci[index - 2] + fibonacci[index - 1]);
            index++;
        } 
        
        return fibonacci;
    }   

    public static string returnFibonacciRecursive(int value, List<int>? fibonacci = null)
    {
        if(fibonacci == null)
        {
            fibonacci = new List<int>();
            fibonacci.Add(1);
            Console.WriteLine(1);
        }

        int currentIndex = fibonacci.Count();
        int num0 = currentIndex - 2 >= 0 ? fibonacci[currentIndex - 2] : 0;
        int num1 = fibonacci[currentIndex - 1];
        fibonacci.Add(num0 + num1);

        if (fibonacci[currentIndex] <= value)
        {
            return fibonacci[currentIndex] + "\n" + returnFibonacciRecursive(value, fibonacci);
        }
        return String.Empty;
    }

}
