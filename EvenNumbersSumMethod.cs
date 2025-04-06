public class EvenNumbersSumMethod
{
    public static int Sum(List<int> numbers)
    {
        var sum = 0;
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
        }

        return sum;
    }
}
