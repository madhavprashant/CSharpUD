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

if(userInput.Length < 3)
{
    Console.WriteLine("short user Input");
}
if(userInput.Length < 10)
{
    Console.WriteLine("Medium user Input");
}
else
{
    Console.WriteLine("User Icnput has exactly 10 characters");  
}
Console.ReadKey();     //Come out of program with user input