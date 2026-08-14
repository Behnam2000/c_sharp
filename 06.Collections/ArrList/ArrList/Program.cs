using System;
using System.Collections;



namespace ArrList;

class Program
{
    static void Main(string[] args)
    {
        // declaring an ArrayList with underfined amount of object:
        ArrayList myArrList = new ArrayList();

        // declaring an ArrayList with defined amount of object:
        ArrayList myArrList2 = new ArrayList(100);


        myArrList.Add(25);
        myArrList.Add("Behnam");
        myArrList.Add(13.53);
        myArrList.Add(13);
        myArrList.Add(23.2);

        // delete elemet with specific value
        myArrList.Remove(13);

        // delete element at specific position
        myArrList.RemoveAt(0);

        System.Console.WriteLine(myArrList.Count);

        double sum = 0;

        foreach (object obj in myArrList)
        {
            if (obj is int)
            {
                sum += Convert.ToDouble(obj);
            }
            else if (obj is double)
            {
                sum += (double)obj;
            }
            else if (obj is string)
            {
                System.Console.WriteLine(obj);
            }

        }

        System.Console.WriteLine(sum);

    }
}
