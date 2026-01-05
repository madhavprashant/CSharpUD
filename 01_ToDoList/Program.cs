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

/// <summary> Simple if else statement to handle user input </summary>
if (userInput == "S")
{
    PrintSelectedOption("Select a TODO");
}
else if (userInput == "A")
{
    PrintSelectedOption("Add a TODO");
}
else if (userInput == "R")
{
    PrintSelectedOption("Remove a TODO");
}
else if (userInput == "E")
{  
    PrintSelectedOption("Exit");
}
else
{
    PrintSelectedOption("Invalid option selected.");
}

Console.ReadKey();                          //Come out of program with user input


/// <summary> Method to print the selected option </summary>
void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected User Input: " + selectedOption);
}
