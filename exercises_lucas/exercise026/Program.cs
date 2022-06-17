class PerfectNumbers
{
    private static void Main()
    {
        int[] perfectNumbers = getPerfectNumbers(8);

        foreach (int num in perfectNumbers)
        {
            Console.WriteLine(num);
        }
    }

    private static int[] getPerfectNumbers(int amount)
    {
        List<int> perfectNumbers = new List<int>();
        int i = 2;
        while (perfectNumbers.Count() < amount)
        {
            if (i == getAllDivisors(i).Sum())
            {
                perfectNumbers.Add(i);
            }
            i++;
        }
        return perfectNumbers.ToArray();
    }

    private static int[] getAllDivisors(int num)
    {
        List<int> divisors = new List<int>();
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                divisors.Add(i);
            }
        }
        return divisors.ToArray();
    }
}