namespace QuizApp;

internal class Program
{
    static void Main(string[] args)
    {
        Question[] questions = new Question[]
        {
            new Question(
                "What is the capital of Japan?",                          // Question text
                new string[] {"Paris", "Hong Kong", "Tokyo", "Seol"},    // Answer Array
                2                                                       // Correct Answer Index
            ),
            new Question(
                "What is 31 + 13",                                       // Question text
                new string[] {"45", "47", "43", "44"},                   // Answer Array
                3                                                       // Correct Answer Index
            ),
            new Question(
                "What king of datatype is for storing characters:",           // Question text
                new string[] {"string", "double", "float", "var"},           // Answer Array
                0                                                           // Correct Answer Index
            ),
            new Question(
                "what the result of: 12 divided by 2? ",                 // Question text
                new string[] {"7", "6", "5", "3"},                      // Answer Array
                1                                                      // Correct Answer Index
            )
        };

        Quiz myQuiz = new Quiz(questions);
        myQuiz.StartQuiz();
    }
}
