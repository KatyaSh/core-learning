//Task3-2-1
Console.WriteLine("enter two numbers and one of the following arithmetic operations - +, -, *, / using space between THEM: 9 + 9, 8 - 4... ");
var userEnter = Console.ReadLine();

string[] parts = userEnter.Split(" ");

var isFirstNumber = double.TryParse(parts[0], out double num1);
var isSecondNumber = double.TryParse(parts[2], out double num2);

switch (parts[1])
{
    case "-":
        Console.WriteLine($"{num1 - num2}");
        break;
    case "+":
        Console.WriteLine($"{num1 + num2}");
        break;
    case "*":
        Console.WriteLine($"{num1 * num2}");
        break;
    case "/":
        if (num2 != 0)
            Console.WriteLine($"{num1 / num2}");
        else
            Console.WriteLine("dividing by zero");
        break;
    default:
        Console.WriteLine("Operation is not present in the list of allowed operations");
        break;
}

//Task3-2-2
Console.WriteLine("enter a number: ");
var userNumber = Console.ReadLine();
bool specifiedNumber = int.TryParse((userNumber), out int a1);
if (specifiedNumber)
{
    if (a1 < 50 && a1 != 37 && a1 >= 32)
    {
        Console.WriteLine("Working!");
    }
    else if (a1 == 0 || a1 == 15)
    {
        Console.WriteLine("Working!");
    }
    else
    {
        Console.WriteLine("Does’t work");
    }
}
else
{
    Console.WriteLine("You specified not a number");
}

//Task3-2-3
Console.WriteLine("enter a number: ");
var enteredNumber = Console.ReadLine();
bool parsedNumber = int.TryParse((enteredNumber), out int parsNum);

Console.WriteLine((parsedNumber && parsNum % 2 == 0) ? $"{parsNum} is Even" : $"{parsNum} is Odd");


