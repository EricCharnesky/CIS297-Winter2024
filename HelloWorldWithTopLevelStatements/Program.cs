// See https://aka.ms/new-console-template for more information

using System.Security;

Console.WriteLine("Hello, World!");
double someNumber = 4.2;
int someOtherNumber = 1;

string name = "Eric Charnesky";

int numberOfCredits = 9;

int numberOfCreditsRequriedForDegree = 60;

Console.WriteLine(someNumber);
Console.WriteLine(someOtherNumber);

Console.WriteLine(name);

// Environment.NewLine is supposed to be better than \n
Console.WriteLine(name + Environment.NewLine + someOtherNumber);

// string interoplation $
Console.WriteLine($"Eric has {numberOfCredits}" +
    $" credits out of {numberOfCreditsRequriedForDegree}");

Console.WriteLine($"Can't wait for Pi Day! {Double.Pi}");

var someInteger = 2;

var lastName = "Charnesky";

// lastName = 2;

Console.WriteLine("Please enter how many servings of salad you want");
int servingsOfSalad;
servingsOfSalad = int.Parse(Console.ReadLine());

Console.WriteLine($"Eric, go eat your {servingsOfSalad} servings of salad!");

//double.Parse(Console.ReadLine());

// integer divided by integer == integer - bye bye decimal place
Console.WriteLine(5 / 2);

Console.WriteLine(5.0 / 2);

Console.WriteLine(5 / (2 * 3) + 5 - 2);

// please please please use  ( ) if you want them
//Console.WriteLine(2/(5x)*3);

Console.WriteLine(int.MinValue);

Console.WriteLine(5.0 / 0);

//Console.WriteLine(5 / 0);

Console.WriteLine($"Please enter {int.MaxValue}");
long maxValueEntered = long.Parse(Console.ReadLine());
Console.WriteLine(maxValueEntered + 1);
Console.WriteLine(long.MaxValue);

// bitwise xor operator ^ - don't do it
Console.WriteLine(2^5);

Console.Beep(440, 1000);

// string literal verbatim
Console.WriteLine(@"I like to use a \lot of backslashes\ because t\hey \are fun");

bool tooMuchSalad = servingsOfSalad > 7;

// string . equals method can be used to ignore case
if (tooMuchSalad && name.Equals( "Eric Charnesky", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Whoa nelly");
}
else
{
    Console.WriteLine("Good job");
}


switch (lastName)
{
    case "Charnesky":
        Console.WriteLine("You're my relative");
        break;
    case "Smith":
        Console.WriteLine("You are related to 2 billion people");
        break;
    default:
        Console.WriteLine("Unknown relatives");
        break;
}

int[] scores = new int[5];

scores[0] = 0;
scores[1] = 0;
scores[2] = 0;
scores[3] = 0;
scores[4] = 0;

int[] fasterScores = { 0, 0, 0, 0, 0 };

// use the array variable Length property to loop
for ( int index = 0; index < fasterScores.Length; index++)
{
    Console.WriteLine($"Enter the value for index {index}");
    fasterScores[index] = int.Parse(Console.ReadLine());
}

// will hard crash on invalid indexes
// fasterScores[10] = 10;

foreach( int value in fasterScores)
{
    Console.WriteLine(value);
}

for ( int scream = 0; scream < 5; scream++)
{
    printSomething();
}


void printSomething()
{
    Console.WriteLine("Let me out of here!");
}

string getFavoriteColor()
{
    return "blue";
}



// instead of a bunch of overloading, we can use defaults
void sayHello(string name = "no name")
{
    Console.WriteLine($"Hi there {name}");
}

// default values have to be the last ones
int addThreeNumbers(int first, int second = 0, int third = 0)
{
    return first + second + third;
}

int addThreeNumbersWithExpression
    (int first, int second = 0, int third = 0) 
    => first + second + third;

Console.WriteLine($"Eric's favorite is {getFavoriteColor()}");

sayHello(name);
sayHello();