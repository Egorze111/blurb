// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// int x = 6;
// Console.WriteLine(x);
// 
// Console.Write("Type a number between 1 and 10 ");
// string valueFromUser = Console.ReadLine();
// 
// // int y = 3;
// 
// int y = int.Parse(valueFromUser);
// 
// if (x > y)
// {
//     Console.WriteLine("greater");
// }
// else if (x < y)
// {
//     Console.WriteLine("Less than");
// }
// else
// {
//     Console.WriteLine("Equal");
// }

string school = "BYU-Idaho";
Console.WriteLine($"I am studying at {school}.");

// practice assignment
// Console.Write("What is your first name? ");
// string first = Console.ReadLine();
// 
// Console.Write("What is your last name? ");
// string last = Console.ReadLine();
// 
// Console.WriteLine($"Your name is {last}, {first} {last}.");
/////////////////

// practice assign 2- Grade Calculator
// Console.Write("What is your grade percentage? ");
// string percentFromUser = Console.ReadLine();
// int percent = int.Parse(percentFromUser);
// if (percent > 0 && percent < 100)
// {
//     if (percent >= 90)
//     {
//         string letterGrade = "A";
//         Console.WriteLine($"Your letter grade is: {letterGrade}.");
//     }
//     else if (percent >= 80 && percent < 90)
//     {
//         string letterGrade = "B";
//         Console.WriteLine($"Your letter grade is: {letterGrade}.");
//     }
//     else if (percent >= 70 && percent < 80)
//     {
//         string letterGrade = "C";
//         Console.WriteLine($"Your letter grade is: {letterGrade}.");
//     }
//     else if (percent >= 60 && percent < 70)
//     {
//         string letterGrade = "D";
//         Console.WriteLine($"Your letter grade is: {letterGrade}.");
//     }
//     else
//     {
//         string letterGrade = "F";
//         Console.WriteLine($"Your letter grade is: {letterGrade}.");
//     }
// }
// else
// {
//     Console.WriteLine("You have not entered in a valid percentage. Please try again.");
// }
// 
// if (percent >= 70 && percent <= 100)
// {
//     Console.WriteLine("You've passed the class! Great work!");
// }
// else
// {
//     Console.WriteLine("You haven't passed the course. Try again next time!");
// }

/////////////////// loops
//string input = "yes";
//while (input == "yes")
//{
//    Console.Write("Do you want to continue? ");
//    input = Console.ReadLine();
//}
//
//string inPut;
//do
//{
//    Console.Write("Do you want to continue again? ");
//    inPut = Console.ReadLine();
//}
//while (inPut == "yes");

//for (int i = 0; i <= 20; i = i+2)
//{
//    Console.WriteLine(i);
//}
//
//Random randomGenerator = new Random();
//int number = randomGenerator.Next(1,11);

////////// prep assignment 3
// magic number guessing

// Console.Write("What is the magic number? ");
// string magicNumber = Console.ReadLine();
// int mNumber = int.Parse(magicNumber);

// Console.WriteLine("Welcome to the ranom number generator!");
// Console.WriteLine("We have a number selected between 1 and 50");
// Random randomGenerator = new Random();
// int number = randomGenerator.Next(1,51);
// 
// string userGuess;
// do
// {
//     Console.Write("What is your guess? ");
//     userGuess = Console.ReadLine();
//     int guess = int.Parse(userGuess);
// 
//     if (guess > number)
//     {
//         Console.WriteLine("Lower");
//     }
//     else if (guess < number)
//     {
//         Console.WriteLine("Higher");
//     }
//     else
//     {
//         Console.WriteLine("You guessed it! ");
//     }
// }
// while (int.Parse(userGuess) != number);

///// lists and iterating through them
// List<string> words = new List<string>();
// List<int> numbers = new List<int>();
// words.Add("phone");
// words.Add("keyboard");
// 
// words.Add("mouse");
// Console.WriteLine(words.Count);
// foreach (string word in words)
// 
// {
//     Console.WriteLine(word);
// }
// 
// for (int i = 0; i < words.Count; i++)
// {
//     Console.WriteLine($"{i+1}. {words[i]}");
// }

///////////// assignment 4
Console.WriteLine("Enter a list of numbers, type 0 when finished");
List<int> numbers = new List<int>();

string uNumber;
do 
{
    Console.Write("Enter number: ");
    uNumber = Console.ReadLine();
    int number = int.Parse(uNumber);
    numbers.Add(number);
}
while (int.Parse(uNumber) != 0);

int total = numbers.Sum();
//// early attempt for the line above
//int total = 0;
//for (int i = 0; i < numbers.Count; i++)
//{
//    total++numbers[i];
//}
int average = total / (numbers.Count - 1);
int biggest = 0;
foreach (int num in numbers)
{
    if (num > biggest)
    {
        biggest = num;
    }
}

Console.WriteLine($"Sum: {total}");
Console.WriteLine($"Average: {average}");
Console.WriteLine($"Largest number: {biggest}");