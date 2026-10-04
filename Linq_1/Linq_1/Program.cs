using System.ComponentModel.Design;

namespace Linq_1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        OddNumbers(numbers);


    }

    static void OddNumbers(int[] numbers)
    {
        System.Console.WriteLine("Odd Numbers: ");

        IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

        System.Console.WriteLine(oddNumbers);

        foreach (int i in oddNumbers)
        {
            System.Console.WriteLine(i);
        }
    }
}
