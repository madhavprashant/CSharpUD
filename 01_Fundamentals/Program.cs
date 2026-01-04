
Console.WriteLine("Hello, learning some operators!");
var number = 10;
var isLargerThan5 = number > 5;
var islargerThanOrEqualTo5 = number >= 5;

/// <summary> checking Modulo/Remiander operator  </summary>
var isEven = number % 2 == 0; // true if number is even
var isModulo3Equals1 = number % 3 == 1; // true if remainder of number divided by 3 equals 1

/// <summary> using && and Or operations </summary>
var isNumberThan5AndEven = number > 5 && isEven;
var isnumberEqualTo20OrLargerThan7OrSmallerThan100 = 
    number == 20 || number > 7 || number < 100;
var isNumberBetween5And15OrGreaterThan0 = 
    number > 5 && number < 15 || number >0;

Console.ReadKey();