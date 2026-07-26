namespace Quiz;

class Program
{
    static void Main(string[] args)
    {
        string question1 = "Capital in Germany?";
        string answer1 = "Berlin";

        string question2 = "What is 2+2?";
        string answer2 = "4";

        string question3 = "What  blue and yellow make? ";
        string answer3 = "Green";

        int score = 0;

        Console.WriteLine(question1);
        string userAnswer1 = Console.ReadLine()!;
        if (userAnswer1.Trim().ToLower() == answer1.ToLower())
        {
            Console.WriteLine("Correct");
            score += 1;
        }
        else
        {
            Console.WriteLine("Wrong Answer . the answer is: " + answer1);
        }

        Console.WriteLine(question2);
        string userAnswer2 = Console.ReadLine()!;
        if (userAnswer2.Trim().ToLower() == answer2.ToLower())
        {
            Console.WriteLine("Correct");
            score += 1;
        }
        else
        {
            Console.WriteLine("Wrong Answer . the answer is: " + answer2);
        }

        Console.WriteLine(question3);
        string userAnswer3 = Console.ReadLine()!;
        if (userAnswer3.Trim().ToLower() == answer3.ToLower())
        {
            Console.WriteLine("Correct");
            score += 1;
        }
        else
        {
            Console.WriteLine("Wrong Answer . the answer is: " + answer3);
        }

        Console.WriteLine($"Quiz Completed youe score is : {score}/3");

        switch (score)
        {
            case 3:
                Console.WriteLine("All Right");
                break;
            case 2:
                Console.WriteLine("Answered 2 question");
                break;
            case 1:
                Console.WriteLine("Answered 1 question");
                break;
            case 0:
                Console.WriteLine("Answered Nothing");
                break;
        }
    }
}
