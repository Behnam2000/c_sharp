// Methods are structured like this
// modifier returnType MethodName(Parameters){
//  code block 
// }


// ------- Void Method -----------

// Definition of a void method that returns nothing
void MyFirstMethod()
{
    Console.WriteLine("MyFirstMethod was called");
}

// Calling a Method
MyFirstMethod();



// -------- Void Method with parameters ----------

// A method that has the parameter "name" of type "String"
// Method declaration
void User(string name)
{
    System.Console.WriteLine("My name is " + name);
}

string userName = "Behnam";

// Calling the method using an Argument called "userName"
User(userName);



int AddTwoValues(int value1, int value2)
{
    return value1 + value2;
}

int myResult = AddTwoValues(53, 3);
System.Console.WriteLine(myResult);