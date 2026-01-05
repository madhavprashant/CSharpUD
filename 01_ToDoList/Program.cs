/// <summary> Print options for a simple TODO list application </summary>
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODO's");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

/// <summary> Wait for user input before closing the console window </summary>
string userInput = Console.ReadLine();
Console.WriteLine("User Input is: " + userInput);

/// <summary> Example of string concatenation </summary>
//var result = "abc"+ "def"+ "ghi";

//var isUserInputABC = userInput == "ABC";

var isUserInputNotABC = userInput != "ABC";     // negation operator flavour 1 is prefered way
var isUserInputNotABC1 = !(userInput == "ABC"); // negation operator flavour 2

if(userInput.Length != 0)
{
    Console.WriteLine("valid User Input!");
    int number = 5;
    string word = "JAN";
    if (number == 5)
    {
        Console.WriteLine("Entered Number is :" + number);
        Console.WriteLine(userInput);
    }
}
else
{
    Console.WriteLine("User Input is empty: " + userInput);  
}
Console.ReadKey();     //Come out of program with user input