namespace OldStyle
{

    internal class Program
    {
        // Field (or instance variable) - sometimes even called global variables.
        int myResult;

        static void Main(string[] args)
        {

            int myResult = AddTwoValues(53, 3);
            System.Console.WriteLine(myResult);


            Program myProgram = new Program();
            int subResult = myProgram.SubstractTwoValues(40, 20);
            System.Console.WriteLine(subResult);
        }

        // if use 'static' keyword, don't need to create an object of the class in the 'Main' method
        static int AddTwoValues(int value1, int value2)
        {
            return value1 + value2;
        }

        // if don't use 'static' keyword, need to create an object of the class in the 'Main' method.
        int SubstractTwoValues(int value1, int value2)
        {
            myResult = value1 - value2;
            return myResult;
        }


    }

}