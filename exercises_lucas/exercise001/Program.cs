using System;

public class programm
{
    private static Dictionary<string, string>[] questions =
    {
        new Dictionary<string, string>
        {
            {"question", "Whats the answer to every question?"},
            {"1", "12"},
            {"2", "42"},
            {"3", "45633"},
            {"4", "7"},
            {"rightAnswer", "2"}
        },
        new Dictionary<string, string>
        {
            {"question", "MM's or Maltesers?"},
            {"1", "MM's"},
            {"2", "Maltesers"},
            {"3", "I like both"},
            {"4", "I hate both"},
            {"rightAnswer", "3"}
        },
        new Dictionary<string, string>
        {
            {"question", "Cola normal or Zero"},
            {"1", "Normal"},
            {"2", "Zero"},
            {"3", "I like both"},
            {"4", "I hate both"},
            {"rightAnswer", "1"}

        },
        new Dictionary<string, string>
        {
            {"question", "MacOS or Windows"},
            {"1", "MacOS"},
            {"2", "Windows"},
            {"3", "Linux"},
            {"4", "I like both"},
            {"rightAnswer", "3"}
        },
        new Dictionary<string, string>
        {
            {"question", "Apple or Android"},
            {"1", "Apple"},
            {"2", "Android"},
            {"3", "I like both"},
            {"4", "Both are shit"},
            {"rightAnswer", "3"}
        },
        new Dictionary<string, string>
        {
            {"question", "MM's or Maltesers?"},
            {"1", "MM's"},
            {"2", "Maltesers"},
            {"3", "I like both"},
            {"4", "7"},
            {"rightAnswer", "2"}
        },
        new Dictionary<string, string>
        {
            {"question", "Who is our almighty lord and savour?"},
            {"1", "Jesus Kistus"},
            {"2", "Satan"},
            {"3", "JUAN"},
            {"4", "God"},
            {"rightAnswer", "3"}
        },
        new Dictionary<string, string>
        {
            {"question", "M?"},
            {"1", "MM's"},
            {"2", "Maltesers"},
            {"3", "I like both"},
            {"4", "7"},
            {"rightAnswer", "2"}
        },
    };
    public static void Main()
    {
        int rightanswers = 0;

        Console.WriteLine("Please select the amount questions:");
        int amount = int.Parse(Console.ReadLine());
        Dictionary<string, string>[] selectedQuestions = getQuestions(amount);
        Console.Clear();

        foreach (var question in selectedQuestions)
        {
            Console.WriteLine(question["question"]);
            Console.WriteLine("=================");
            Console.WriteLine("");
            Console.WriteLine($"1. {question["1"]}");
            Console.WriteLine($"2. {question["2"]}");
            Console.WriteLine($"3. {question["3"]}");
            Console.WriteLine($"4. {question["4"]}");
            Console.WriteLine("");
            Console.WriteLine("Choose wisely:");
            if(checkAnswers(Console.ReadLine(), question["rightAnswer"]))
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Correct!");
                rightanswers++;
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("False!");
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        Console.WriteLine("============================");
        Console.WriteLine($"You got {rightanswers} out of {amount} right.");
        Console.WriteLine("============================");
    }

    private static  Dictionary<string, string>[] getQuestions(int questionAmount)
    {
        Random random = new ();
        Dictionary<string, string>[] selectedQuestions = new Dictionary<string, string>[questionAmount];
        int[] chosenNumbers = new int[questionAmount];

        for (int i = 0; i < questionAmount; i++)
        {
            int index;
            do
            {
                index = random.Next(7);
            }while (chosenNumbers.Contains(index));

            selectedQuestions[i] = questions[index];
            chosenNumbers[i] = index; 
        }

        return selectedQuestions;
    }

    private static  bool checkAnswers(string selectedaAnswer, string rightAnswer)
    {
        return selectedaAnswer.Equals(rightAnswer);
    }
}