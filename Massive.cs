public static class Massive
{
    public static void ShowMassiveElements(int[] massive)
    {
        try
        {
            Console.WriteLine("Specify index of element in massive:");
            var inputedValue = Console.ReadLine();
            var checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;
            var inputedNumber = Int32.Parse(checkedValue);
            var massiveElement = massive[inputedNumber];
            Console.WriteLine($"Massive element with index {inputedValue} has value {massiveElement}");
        }

        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Excepton occurs : {ex.Message}");
            Console.WriteLine(ex);
        }

        catch (FormatException ex)
        {
            Console.WriteLine($"Excepton occurs : {ex.Message}");
            Console.WriteLine(ex);
        }

        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Excepton occurs: IndexOutOfRangeException");
            Console.WriteLine(ex);
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Excepton occurs: {ex.Message}");
            Console.WriteLine(ex);
        }
    }
}