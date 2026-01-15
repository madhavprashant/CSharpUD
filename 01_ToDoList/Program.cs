/// <summary> Print options for a simple TODO list application </summary>
//Console.WriteLine("Hello!");
//Console.WriteLine("What do you want to do?");
//Console.WriteLine("[S]ee all TODO's");
//Console.WriteLine("[A]dd a TODO");
//Console.WriteLine("[R]emove a TODO");
//Console.WriteLine("[E]xit");

///// <summary> Wait for user input before closing the console window </summary>
//string userInput = Console.ReadLine();
//Console.WriteLine("User Input is: " + userInput);

//bool isLong = IsLong(userInput);

///// <summary> Method to check if user input length is greater than 1 </summary>
//bool IsLong(string input)
//{
//    return input.Length > 5;
//}

/// <summary> Simple if else statement to handle user input </summary>
//if (userInput == "S")
//{
//    PrintSelectedOption("Select a TODO");
//}
//else if (userInput == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userInput == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userInput == "E")
//{  
//    PrintSelectedOption("Exit");
//}
//else
//{
//    PrintSelectedOption("Invalid option selected.");
//}

//Console.ReadKey();

///// <summary> Method to print the selected option </summary>
//void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected User Input: " + selectedOption);
//}

/// <summary> while loop example </summary>
/// 
//var number = 0;
//while (number < 5)
//{
//    number++;
//    Console.WriteLine($"number is: {number}");
//}
//Console.WriteLine("Finished loop.");
//Console.ReadKey();

//Console.WriteLine("Enter a word:");
//var userWord = Console.ReadLine();
//while (userWord.Length < 15)
//{
//    userWord = userWord + 'a';
//    Console.WriteLine(userWord);
//}
//Console.WriteLine("Word length has reached 15 characters. Finishing Loop ");
//Console.ReadKey();

var firstNumber = int.Parse(Console.ReadLine());
var lastNumber = int.Parse(Console.ReadLine());
var sum = 0;
while (firstNumber != lastNumber)
{
    if (firstNumber > lastNumber)
    {
        Console.WriteLine($"Loop Finished, Sum is {sum}");
        return;
    }
    sum += firstNumber;
    firstNumber += 1;
}
Console.WriteLine(sum);
Console.ReadKey();