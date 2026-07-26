// declare an array
int[] myIntArray = new int[5];

// assigned values to the array
myIntArray[0] = 5;
myIntArray[1] = 12;
myIntArray[2] = 13;
myIntArray[3] = 14;
myIntArray[4] = 15;

System.Console.WriteLine(myIntArray[3]);

// declarign and setting values for arrays in the same line:

int[] myIntArray2 = [3, 23, 25, 27, 29];


//-------- Two Dimensional Arrays

int[,] array2D = new int[3, 3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

// intialize
int[,] array2DIn = { { 1, 2 }, { 3, 4 } };
// [1] [2]  // row 0
// [3] [4]  // row 1

System.Console.WriteLine(array2DIn[0, 0]);
array2DIn[0, 0] = 5;
System.Console.WriteLine(array2DIn[0, 0]);



// ------- Multi-Dementional Arrays

string[,] ticTacToeField =
{
  {"O", "X", "X"},
  {"O", "O", "X"},
  {"X","X", "O"},
};

System.Console.WriteLine(ticTacToeField[1, 2]);



//------- Three Dimensional Arrays

int[,,] array3DDeclaration = new int[3, 3, 3];

//initialize
string[,,] simple3DArray =
{
    {
        {"000", "001"},
        {"010", "011"}

    },
    {
        {"100", "101"},
        {"100", "111"}
    }
};

System.Console.WriteLine(simple3DArray[0, 1, 0]);

