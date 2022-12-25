
//Doubles can have a decimal point or may be integer
//Example: 1.23 , 43, 4,51, 351

double averageAge;
double notAverageAge;
//If all values are integer, it will return integer.
//If we want double, we can simply add a .0 to make it double
averageAge = (43.0 + 22 + 62) / 3;


notAverageAge = 42.3;

System.Console.WriteLine(averageAge);
System.Console.WriteLine(notAverageAge);

//It is not recommended to use integer when dividing

//Note, double also rounds the value up or down after 15digits.
notAverageAge = 1.0/ 3;
System.Console.WriteLine(notAverageAge);

