// in strings \ is an "Escape character"
// \n stands for "New Line"
// \r - carriage return
string myStr = "    |\r\n     |\r\n    / \\\r\n   / _ \\\r\n  |.o '.|\r\n  |'._.'|\r\n  |     |\r\n ,'|  | |`.\r\n/  |  | |  \\\r\n|,-'--|--'-.|";

for (int counter = 10; counter >= 0; counter--)
{
    Console.Clear();
    Console.WriteLine("Conter is " + counter);
    Console.WriteLine(myStr);
    myStr = "\r\n " + myStr;
    Thread.Sleep(1000);
}

System.Console.WriteLine("The rocket has landed");