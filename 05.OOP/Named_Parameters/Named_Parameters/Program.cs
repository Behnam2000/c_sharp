namespace Named_Parameters;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(AddNum(15, 35));

        // Using Named Parameter
        System.Console.WriteLine(AddNum(firstNum: 23, secondNum: 35));
    }

    static int AddNum(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }
}
