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
Console.Write("What is your grade percentage? ");
string percentFromUser = Console.ReadLine();
int percent = int.Parse(percentFromUser);
if (percent > 0 && percent < 100)
{
    if (percent >= 90)
    {
        string letterGrade = "A";
        Console.WriteLine($"Your letter grade is: {letterGrade}.");
    }
    else if (percent >= 80 && percent < 90)
    {
        string letterGrade = "B";
        Console.WriteLine($"Your letter grade is: {letterGrade}.");
    }
    else if (percent >= 70 && percent < 80)
    {
        string letterGrade = "C";
        Console.WriteLine($"Your letter grade is: {letterGrade}.");
    }
    else if (percent >= 60 && percent < 70)
    {
        string letterGrade = "D";
        Console.WriteLine($"Your letter grade is: {letterGrade}.");
    }
    else
    {
        string letterGrade = "F";
        Console.WriteLine($"Your letter grade is: {letterGrade}.");
    }
}
else
{
    Console.WriteLine("You have not entered in a valid percentage. Please try again.");
}

if (percent >= 70 && percent <= 100)
{
    Console.WriteLine("You've passed the class! Great work!");
}
else
{
    Console.WriteLine("You haven't passed the course. Try again next time!");
}