using System;

public class programm
{
    private const string questionKey = "question";
    private const string rightAnswerkey = "rightAnswer";

    private static Dictionary<string, string>[] questions =
    {
        createQuestion("Whats the answer to every question?", "12", "42", "45633", "7", "2"),
        createQuestion("MM's or Maltesers?", "MMs", "Maltesers", "I like both", "I hate both", "3"),
        createQuestion("Cola normal or Zero", "Normal", "Zero", "I like both", "I hate both", "1"),
        createQuestion("Cola normal or Zero", "Normal", "Zero", "I like both", "I hate both", "1"),
        createQuestion("MacOS or Windows", "MacOS", "Windows", "Linux", "I hate both", "3"),
        createQuestion("Apple or Android", "Apple", "Android", "I like both", "Both are shit", "3"),
        createQuestion("Who is our almighty lord and savour?", "Jesus Kistus", "Satan", "JUAN", "God", "3"),
        createQuestion("Who is playing spiderman in the latest spiderman movies?", "Sam Ramy", "Peter Parker", "Tom Holland", "Zach snider", "3"),
        createQuestion("What is Super Marios second name?", "Mussolini", "Lombardi", "Luigi", "Mario", "4"),
        createQuestion("When did the first Star Wars movie come out?", "1977", "2004", "1990", "1973", "1"),
        createQuestion("Who played Batman in 1989", "Christian Bale", "Ben Affleck", "Robert Pattinson", "Michael Keaton", "4"),
        createQuestion("Pi", "3.1415926", "3.1428571", "3.1414213", "69", "1"),
    };
    public static void Main()
    {
        int rightanswers = 0;

        do
        {

        }while(§)


        foreach (var question in selectedQuestions)
        {
            Console.WriteLine(question[questionKey]);
            Console.WriteLine("=================");
            Console.WriteLine("");
            Console.WriteLine($"1. {question["1"]}");
            Console.WriteLine($"2. {question["2"]}");
            Console.WriteLine($"3. {question["3"]}");
            Console.WriteLine($"4. {question["4"]}");
            Console.WriteLine("");
            Console.WriteLine("Choose wisely:");

            if(Console.ReadLine().Equals(question[rightAnswerkey]))
            {
                Console.Clear();
                Console.WriteLine("");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ForegroundColor = ConsoleColor.White;
                rightanswers++;
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("False!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.Clear();
            }
        }
        Console.WriteLine("============================");
        Console.WriteLine($"You got {rightanswers} out of {amount} questions right.");
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
                index = random.Next(10);
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

    private static Dictionary<string, string> createQuestion(string question, string answer1, string answer2, string answer3, string answer4, string rightanswer)
    {
        return new Dictionary<string, string>
        {
            {questionKey, question},
            {"1", answer1 },
            {"2", answer2 },
            {"3", answer3},
            {"4", answer4},
            {rightAnswerkey, rightanswer},
        };
    }
}