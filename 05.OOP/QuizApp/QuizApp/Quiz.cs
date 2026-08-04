namespace QuizApp;

internal class Quiz
{
    private Question[] _questions;
    private int _score;

    public Quiz(Question[] questions)
    {
        this._questions = questions;
        _score = 0;
    }

    public void StartQuiz()
    {
        System.Console.WriteLine("Welcome to the quiz");
        int questionNumber = 1; // to display question numbers

        foreach (Question question in _questions)
        {
            System.Console.WriteLine($"Question {questionNumber++}:");
            DisplayQuestion(question);
            int userChoice = GetUserChoice();
            if (question.IsCorrectAnswer(userChoice))
            {
                System.Console.WriteLine("Correct");
                _score++;
            }
            else
            {
                System.Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
            }
        }
        DisplayResults();
    }

    private void DisplayResults()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Results                                 ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();

        System.Console.WriteLine($"Quiz finished. Your score is: {_score} out of {_questions.Length}");

        double percentage = (double)_score / _questions.Length;

        if (percentage >= 0.8)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Excellent Work!");
        }
        else if (percentage >= 0.5)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Good effort!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Keep practicing");
        }
        Console.ResetColor();
    }


    private void DisplayQuestion(Question question)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Question                                ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine(question.QuestionText);

        for (int i = 0; i < question.Answers.Length; i++)
        {
            System.Console.ForegroundColor = ConsoleColor.Cyan; // changes the text color
            System.Console.Write("  ");
            System.Console.Write(i + 1);
            System.Console.ResetColor();  // restes the forground (text) color
            System.Console.WriteLine($". {question.Answers[i]}");
        }
    }

    private int GetUserChoice()
    {
        System.Console.WriteLine("Your Answer (number): ");
        string input = Console.ReadLine()!;
        int choice = 0;
        while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
        {
            System.Console.WriteLine("invalid choice !!");
            input = Console.ReadLine()!;
        }

        return choice - 1; // adjust to 0-indexed array 
    }
}
