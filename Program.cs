// List
// Task 1.1
List<int> enteredNumbers = new List<int>();
for (int i = 0; i < 6; i++)
{
    Console.Write("Enter a number: ");
    var input = Console.ReadLine();
    bool parseResult = int.TryParse(input, out int numberFromUser);

    if (parseResult)
    {
        enteredNumbers.Add(numberFromUser);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        i--;
    }
}

var sum = EvenNumbersSumMethod.Sum(enteredNumbers);
Console.WriteLine(sum);

// Task 1.2
List<int> myNumbers = new List<int>() { 1, 3, 7, 8, 1, 2, 5, 10, 4, 15 };
var sumMyNumbers = EvenNumbersSumMethod.Sum(myNumbers);
Console.WriteLine(sumMyNumbers);

// Task 1.3
List<String> words = new List<String>() { "moon", "taxi", "money", "bamby", "task", "casco", "you", "me" };
List<String> wordsSorted = SortingOfWord.wordsSorting(words);
foreach (var word in wordsSorted)
{
    Console.WriteLine(word);
}

// Task 1.4

Console.Write("Enter a required lenght of word: ");
var input1 = Console.ReadLine();
bool parseResult1 = int.TryParse(input1, out int searchLenght);
List<String> wordsSortedonLeght = new List<string>();

if (parseResult1)
{
    wordsSortedonLeght = SortingOfWord.wordsSortingCertainLenght(words, searchLenght);
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}

foreach (var word in wordsSortedonLeght)
{
    Console.WriteLine(word);
}

// Linked list
// Task 2.1
int[] initialValues = { 2, 4, 3, 2, 8, 2, 5, 1, 2 };
LinkedList<int> initialLinkedList = new LinkedList<int>(initialValues);
Console.WriteLine("Elements before insertion:");
foreach (var number in initialLinkedList)
{
    Console.WriteLine(number);
}

AddToLinkedListMethod.AddedValuesToList(initialLinkedList, 2, 10);
Console.WriteLine("Elements after insertion:");
foreach (var number in initialLinkedList)
{
    Console.WriteLine(number);
}

// Task 2.2
int[] initialValues1 = { 1, 3, 4, 7, 12 };
int[] initialValues2 = { 1, 5, 7, 9, 3 };
LinkedList<int> initialValuesList1 = new LinkedList<int>(initialValues1);
LinkedList<int> initialValuesList2 = new LinkedList<int>(initialValues2);
var currentNode1 = initialValuesList1.First;
var currentNode2 = initialValuesList2.First;
LinkedList<int> result = MergeLinkedListsMethod.MergedLists(initialValuesList1, initialValuesList2);
foreach (var number in result)
{
    Console.WriteLine($" Merged Linked list: {number}");
}

// QUEUE & STACK
// Task 3.1
Queue<int> myQueue = new Queue<int>(new int[] { 5, 3, 6, 2, 7, 8, 9 });
var queue = QueueMethods.SwapFirstAndLastMethod(myQueue);
foreach (var elem in queue) Console.WriteLine(elem);

// Task 3.2
Queue<int> myQueue1 = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
var queue1 = myQueue.Reverse();
foreach (var elem in queue1) Console.WriteLine(elem);


// Task 3.3
Stack<int> myStack = new Stack<int>(new int[] { 3, 2, 5, 1, 4 });
var stack = StackMethods.AscSorting(myStack);
foreach (var elem in stack) Console.WriteLine(elem);

// Task 3.4
string testData1 = "((a+b))))";
string testData2 = ")a+b(";
Console.WriteLine(StackMethods.AreParenthesesBalanced(testData1));
Console.WriteLine(StackMethods.AreParenthesesBalanced(testData2));

// DICTIONARY
// Task 4.1
Dictionary<string, int> kateDictionary = new Dictionary<string, int>();
kateDictionary.Add("Kate", 5);
kateDictionary["Vita"] = 10;
Console.WriteLine($"Name: Kate, Age: {kateDictionary["Kate"]}");

// Task 4.2
List<int> intList = new List<int> { 1, 10, 2, 15, 24, 17, 50, 63, 47 };
List<string> stringList = new List<string> { "cat", "dog", "apple", "table", "cup", "grass", "headphones", "monitor", "program" };
var mergedDictionary = DictionaryMethods.SortAndMergeLists(intList, stringList);

foreach (var pair in mergedDictionary)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

// Task 4.3

CityDictionaryMethods cityManager = new CityDictionaryMethods();
cityManager.AddCity("New York", new City(8000000, 450));
cityManager.AddCity("Paris", new City(390000, 500));
cityManager.AddCity("Chicago", new City(2700000, 580));
cityManager.AddCity("Minsk", new City(1900000, 250));
cityManager.AddCity("London", new City(3000000, 500));

cityManager.SortByArea();
cityManager.BrowseByPopulationDescending();
cityManager.CountTotalPopulation();