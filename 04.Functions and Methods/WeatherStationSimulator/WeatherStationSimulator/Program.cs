namespace WeatherStationSimulator;

class Program
{

    // static int[] temperature = { };                              // BAD practice          

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of days to simulate: ");
        int days = int.Parse(Console.ReadLine()!);

        int[] temperature = new int[days];
        string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
        string[] weatherConditions = new string[days];

        Random random = new Random();

        for (int i = 0; i < days; i++)
        {
            temperature[i] = random.Next(-10, 40);
            weatherConditions[i] = conditions[random.Next(conditions.Length)];
        }

        System.Console.WriteLine($"Average Temprerature: {CalculateAverage(temperature):F2}°C");
        System.Console.WriteLine($"The max temp was: {temperature.Max()}");
        System.Console.WriteLine($"The min temp was: {temperature.Min()}");

        System.Console.WriteLine($"My min temp: {MinTemperature(temperature)}");

        System.Console.WriteLine($"Most common condition is: {MostCommonCondition(conditions)}");
    }

    // static double AverageTemp()
    // {
    //     double sum = temperature.Sum();
    //     double average = sum / temperature.Length;              // BAD practice

    //     return average;

    // }

    static double CalculateAverage(int[] temperature)
    {
        double sum = 0;

        // foreach (int i in temperature)
        // {
        //     sum += i;
        // }

        for (int i = 0; i < temperature.Length; i++)
        {
            sum += temperature[i];
        }

        double average = sum / temperature.Length;

        return average;
    }



    // ---------- Max and Min ----------

    static int MinTemperature(int[] temperature)
    {
        int min = temperature[0];

        foreach (int temp in temperature)
        {
            System.Console.WriteLine(temp);   //. Test to see the array 

            if (temp > min)
            {
                min = temp;
            }
        }

        return min;

    }


    // ---------- Most common weather condition -------

    static string MostCommonCondition(string[] conditions)
    {
        int count = 0;
        string mostCommon = conditions[0];

        for (int i = 0; i < conditions.Length; i++)
        {

            int tempCount = 0;
            for (int j = 0; j < conditions.Length; j++)
            {
                if (conditions[j] == conditions[i])
                {
                    tempCount++;
                }
            }
            if (tempCount > count)
            {
                count = tempCount;
                mostCommon = conditions[i];
            }
        }

        return mostCommon;

    }


}
