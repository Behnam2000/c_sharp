namespace Variables;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // declare a (string) variable
        string myFriendName;
        // assign a value to the myFriendName variable
        myFriendName = "Behnam";

        // use/access the variable
        Console.WriteLine(myFriendName);

        // overwriting the variable value
        myFriendName = "Bahar";
        Console.WriteLine(myFriendName);


        // declaring a variable and assig a value to it
        string myFriendsName = "Alireza";
        Console.WriteLine(myFriendsName);


        // Referency Type
        string myName = "Behnam Safari";

        // defining or setting up a variable
        string petsName;

        // initialize variable
        petsName = "Daisy";
        Console.WriteLine($"my pet is {petsName}");

        petsName = "Barky";
        Console.WriteLine($"my pet is {petsName}");

        // Value Types
        int myAge = 35;

        double pi = 3.14;

        byte age = 255;

        short linkdinConnections = 32550;

        long phoneNumber = 09123345678;



        // ---- implicitly and explicitly typed variables ------- //

        // implicity
        var myFavoriteGenre = "Rock";
        var myFavoriteNumber = 13;


        // explicitly
        string myFriendsName2 = "Dave";
        int myNum = 23;


        // ----- char Datatype ------ //
        char myCharacter = '$';




        // ----- String Manipulation with String Formmating ----- //

        int num = 10;
        double price = 19.93;
        string name = "Frank";

        // Interpolation
        Console.WriteLine($"The number is {num}");
        // String concatination
        Console.WriteLine("The number is " + num);

        // String formmating
        Console.WriteLine("The number is {0}, and the price is {1}, and the name is {2}", num, price, name);



        // ------- Using special characters in strings with the escape character ------- //

        string s1 = "thsis is a \"string\" with \na backslash \\ and a colon: ";
        Console.WriteLine(s1);



    }
}
