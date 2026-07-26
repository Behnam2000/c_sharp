for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine(i);
    if (i == 3)
    {
        //System.Console.WriteLine("I've had enough");
        //break;                 // finishs the entire loop execution.
        continue;               // goes to the next iteration of the loop that you're currently in.
    }
    System.Console.WriteLine(i);
}