
//FirstName is the holder of the data
string firstName = string.Empty; 
string secondName= string.Empty;
string filePath = string.Empty;
string fileSecondPath = string.Empty;
firstName = "kamil";
secondName = "ertekin";
// Any character after escape \ is turned into string, so you need \\ (first one turning the second into string) 
filePath = "C:\\Temp\\Demo";
//You can use the @ to turn the line into literal string (ALL OF IT)
fileSecondPath = @"C:\Temp\Demo";

//String Interpolation + String Literal Converter 
string testString = @$"The file for {firstName} is at C:\SampleFiles";

//String interpolation
Console.WriteLine($"Hello {firstName} {secondName}");
System.Console.WriteLine(testString);

//expertsExchange
