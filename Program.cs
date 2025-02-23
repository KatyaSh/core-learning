using Library;

// Task 1-1 
{
    Console.WriteLine("Hi! What’s your name ?");
    var name = Console.ReadLine();
    Console.WriteLine($"Nice to meet you {name}");
}

// Task 3-1
{
    int num = 20;
    num += 5;
    Console.WriteLine(num);
}

// Task 3-2
{
    int numberOfYears;
    int numberOfMonths;
    int numberOfDays;

    Console.Write("Enter a four-digit number that represents n days:");
    var input = Console.ReadLine();
    bool isParsed = int.TryParse(input, out int days);

    if (isParsed && days >= 0)
    {
        numberOfYears = days / 365;
        numberOfMonths = (days - (numberOfYears * 365)) / 30;
        numberOfDays = (days - (numberOfYears * 365)) % 30;
        Console.WriteLine($"You specified {numberOfYears} years, {numberOfMonths} months and {numberOfDays} days");
    }
    else
    {
        Console.WriteLine("You specified negative number or entered not a number");
    }
}

// Task 3-3
{
    Console.Write("Enter your number:");
    var userNumberSpec = Console.ReadLine();
    bool isParsedResult = int.TryParse(userNumberSpec, out int parsedNumberSpec);

    if (isParsedResult)
    {
        int result = parsedNumberSpec + parsedNumberSpec * 2;
        Console.WriteLine("Your result is: " + result);
    }
    else
    {
        Console.WriteLine("You specified not a number");
    }
}

// Task 3-4
{
    int a = -34; // отрицательное целое число < 0
    uint b = 4; //положительное целое число > 0
    string c = "Hello"; //слово
    char d = 'R'; //символ
    double e = 23.093433222; // у double больше символов после запятой, хранит более точные данные
    uint f = 40000; //положительное целое число > 0
    bool g = true; //логический тип
    int h = 0; //Просто целое число
}

// Task 3-5
{
    Console.Write("Enter your number:");
    var userNumberSpecif = Console.ReadLine();
    bool isParsedNumber = int.TryParse(userNumberSpecif, out int parsedNumberSpecif);

    if (isParsedNumber && Math.Abs(parsedNumberSpecif) % 2 == 0)
    {
        Console.WriteLine("Your number is: Even");
    }
    else if (isParsedNumber && Math.Abs(parsedNumberSpecif) % 2 == 1)
    {
        Console.WriteLine("Your number is: Odd");
    }
    else
    {
        Console.WriteLine("You specified not a number");
    }
}

// Task 4-1
{
    int sum = 0;

    Console.Write("Enter any positive number: ");
    var input = Console.ReadLine();
    bool isParsedPositive = int.TryParse(input, out int number);

    if (isParsedPositive && number >= 0)
    {
        for (int i = 0; i <= number; i++)
        {
            sum += i;
        }
        Console.WriteLine($"result of the calculation: {sum}");
    }
    else
    {
        Console.WriteLine("You specified negative number or entered not a number");
    }
}

// Task 4-2
{
    int j = 0;
    int number3 = 3;
    int result;

    while (j < 10)
    {
        result = j * number3;
        Console.WriteLine($"{number3} * {j} = {result}");
        j++;
    }
}

// Task 4-3
{
    int[] numbers = new int[] { 3, 5, 9, 8, 15 };
    int product = 1;

    foreach (int i in numbers)
    {
        product *= i;
    }
    Console.WriteLine("the product of these numbers:" + product);
}

// Task 4-4
{
    int count = 0;
    int dividedNumber = 2048;

    while (dividedNumber > 10)
    {
        dividedNumber = dividedNumber / 2;
        count++;
    }
    Console.WriteLine($"2048 can be divided by 2: {count} times");
}

// Task 4-5
{
    string[] words = new string[] { "Pts", "Hello", "Kus", "string", "Hello" };
    string helloWord = "Hello";

    foreach (string word in words)
    {
        if (string.Equals(word, helloWord))
        {
            Console.WriteLine("Labas");
            break;
        }
    }
}

// Task 4-6
{
    int[] numbersArr = new int[] { 1, 5, 2, 3, 5, 4, 6 };

    int sumOfNumbers = numbersArr[0] + numbersArr[^1];
    Console.WriteLine(sumOfNumbers);
}

// Task 4-7
{
    int[] numbersArr = new int[] { 9, 5, 2, 3, 5, 4, 6 };
    int sumOfIndexes;
    int minElement = numbersArr[0];
    int maxElement = numbersArr[0];
    int indexMin = 0;
    int indexMax = 0;

    for (int i = 1; i < numbersArr.Length; i++)
    {
        if (minElement > numbersArr[i])
        {
            minElement = numbersArr[i];
            indexMin = i;
        }

        if (maxElement < numbersArr[i])
        {
            maxElement = numbersArr[i];
            indexMax = i;
        }
    }
    sumOfIndexes = indexMin + indexMax;
    Console.WriteLine(sumOfIndexes);
}

// Task 4-8
{
    int[] numbersArr = new int[] { 5, 1, 2, 3, 5, 4, 6 };
    int temp;

    foreach (int number in numbersArr)
    {
        Console.WriteLine(number);
    }

    for (int i = 0; i < numbersArr.Length - 1; i++)
    {
        for (int k = i + 1; k < numbersArr.Length; k++)
        {
            if (numbersArr[i] > numbersArr[k])
            {
                temp = numbersArr[i];
                numbersArr[i] = numbersArr[k];
                numbersArr[k] = temp;
            }
        }
    }
    Console.WriteLine("ASC Order Output");
    foreach (int number in numbersArr)
    {
        Console.WriteLine(number);
    }
}

// Task 4-9
{
    for (int a = 1; a < 11; a++)
    {
        int b = 1;

        while (b < 11)
        {
            int result;
            result = a * b;
            Console.WriteLine($"{a} * {b} = {result}");
            b++;
        }
        Console.WriteLine("-------------------");
    }
}

// Task 4-10
{
    int[][] nums = new int[2][];
    nums[0] = new int[6] { 1, 2, 3, 4, 5, 6 };
    nums[1] = new int[3] { 7, 8, 9 };

    for (int i = 0; i < nums.Length; i++)
    {
        for (int с = 0; с < nums[i].Length; с++)

            if (с == 2)
            {
                Console.Write($"{nums[i][с]} \n");
            }
            else if (с != 2)
            {
                Console.Write($"{nums[i][с]} \t");
            }
        Console.WriteLine();
    }
}

// Task 4-11
{
    int[] oldArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.WriteLine("Old array");

    foreach (int number in oldArray)
    {
        Console.Write($"{number} \t");
    }

    Console.WriteLine();

    int[] newArray = new int[oldArray.Length + 2];

    for (int i = 0; i < oldArray.Length; i++)
    {
        newArray[i + 1] = oldArray[i];
    }

    // 1 & 2  tasks
    newArray[0] = -1;
    newArray[newArray.Length - 1] = 11;

    Console.WriteLine("A new array with new elements in the beginning and the end");

    foreach (int i in newArray)
    {
        Console.Write($"{i} \t");
    }

    Console.WriteLine();

    // 3 task
    int[] newArray1 = new int[newArray.Length + 1];
    int insertIndex = 3;

    for (int i = 0; i < insertIndex; i++)
    {
        newArray1[i] = newArray[i];
    }

    newArray1[insertIndex] = 12;

    for (int i = insertIndex + 1; i < newArray1.Length; i++)
    {
        newArray1[i] = newArray[i - 1];
    }

    Console.WriteLine("A new array with new element at 4 position");

    foreach (int i in newArray1)
    {
        Console.Write($"{i} \t");
    }

    // 4 task
    int[] newArray2 = new int[newArray1.Length - 1];

    for (int i = 0; i < newArray2.Length; i++)
    {
        newArray2[i] = newArray1[i + 1];
    }

    Console.WriteLine("\nA new array with removed element");

    foreach (int i in newArray2)
    {
        Console.Write($"{i} \t");
    }

    // 5 task -  array from two arrays
    int[][] numsNew = new int[2][];
    numsNew[0] = oldArray;
    numsNew[1] = new int[3] { 100, 200, 300 };

    Console.WriteLine("\nA new array from two arrays");

    foreach (int[] row in numsNew)
    {
        foreach (int el in row)
        {
            Console.Write($"{el} \t");
        }
        Console.WriteLine();
    }
}

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

// Task3-2-2
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
        Console.WriteLine("Doesn’t work");
    }
}
else
{
    Console.WriteLine("You specified not a number");
}

// Task3-2-3
Console.WriteLine("enter a number: ");
var enteredNumber = Console.ReadLine();
bool parsedNumber = int.TryParse((enteredNumber), out int parsNum);

Console.WriteLine((parsedNumber && parsNum % 2 == 0) ? $"{parsNum} is Even" : $"{parsNum} is Odd");

BankAccount bankAccount = new BankAccount();
bankAccount.DisplayAccountInfo();
bankAccount.AddDeposite(20);

Console.Write("enter operation which you want : 'add deposite' or 'withdrow money'");
var operationChosen = Console.ReadLine();

if (operationChosen == "add deposite")
{
    Console.Write("enter deposite amount: ");
    var input = Console.ReadLine();
    bool isParsed = int.TryParse(input, out int deposite);

    if (isParsed)
    {
        bankAccount.AddDeposite(deposite);
        bankAccount.DisplayAccountMoneyInfo();
    }
    else
    {
        Console.Write("you entered not a number");
    }
}
else if (operationChosen == "withdrow money")
{
    Console.Write("enter summ you want to withdrow: ");
    var input = Console.ReadLine();
    bool isParsed = int.TryParse(input, out int withdrow);

    if (isParsed)
    {
        bankAccount.WithdrowMoney(withdrow);
        bankAccount.DisplayAccountMoneyInfo();
    }
    else
    {
        Console.Write("you entered not a number");
    }
}

Client client1 = new Client("Alice", "Johnson", 30, true);
Client client2 = new Client("Bob", "Smith", 45, false);

OfficeWorker analyst = new OfficeWorker("John", "Doe", 28, true, "Financial Analyst");
OfficeWorker loanSpecialist = new OfficeWorker("Emma", "Brown", 35, false, "Loan Specialist");
Manager manager = new Manager("David", "Wilson", 40, true);
manager.FirePerson(loanSpecialist);
client1.TakeLoan(true);
client2.TakeLoan(false);
analyst.QuitFromBank(manager.isFired);
manager.QuitFromBank(loanSpecialist.isFired);
Console.WriteLine(client1);
Console.WriteLine(client2);
Console.WriteLine(analyst);
Console.WriteLine(loanSpecialist);
Console.WriteLine(manager);

var rabotnik = new Employee("Pasha", "Bubkin", 23, "gruzchik");
var pracauniki = new Employee[] { rabotnik, new Employee("Venus", "Papus", 45, "director"), new Employee("Mada", "Petrovna", 56, "buhgalter") };
var factory = new Factory("Rassvet");
var factory1 = new Factory();
var factory2 = new Factory("Mechta", pracauniki);

factory.AddNewEmployee(rabotnik);
Console.WriteLine("______________");

factory1.NumberOfEmployees();
Console.WriteLine("______________");

factory2.PrintEmployeesInfoCertainPositin("director");
Console.WriteLine("______________");

factory1.PrintEmployeesInfo();
class Factory
{
    private string name;
    public string Name { get; set; }

    private Employee[] employees;
    public Employee[] Employees { get; set; }

    public Factory()
    {
        this.name = "fabrika Norblina";
        this.employees = new Employee[] { (new Employee("Jula", "Smith", 35, "Accountant")), (new Employee("Tom", "Peter", 30, "Stolyar")) };
    }

    public Factory(string name)
    {
        this.name = name;
        this.employees = new Employee[] { (new Employee("Samanta", "Torr", 35, "Cleaner")), (new Employee("Vanessa", "Paradi", 23, "Director")) };
    }

    public Factory(string name, Employee[] employees)
    {
        this.name = name;
        this.employees = employees;
    }

    public void NumberOfEmployees() => Console.WriteLine(employees.Length);

    public void AddNewEmployee(Employee personNew)
    {
        var employeesNew = new Employee[employees.Length + 1];

        for (int i = 0; i < employees.Length; i++)
        {
            employeesNew[i] = employees[i];
        }

        employeesNew[employees.Length] = personNew;

        foreach (Employee employee in employeesNew)
        {
            employee.PrintInfo();
        }
    }

    public void PrintEmployeesInfo()
    {
        foreach (Employee employee in employees)
        {
            employee.PrintInfo();
        }
    }


    public void PrintEmployeesInfoCertainPositin(string position)
    {
        foreach (Employee employee in employees)
        {
            if (position.Equals(employee.Position))
            {
                employee.PrintInfo();
            }
        }
    }
}