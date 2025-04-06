public class SortingOfWord
{
    public static List<String> wordsSorting(List<String> words)
    {
        List<String> sortedWords = new List<String>();
        foreach (String word in words)
        {
            if (word.Length == 5)
            {
                sortedWords.Add(word);
            }
        }

        return sortedWords;
    }

    public static List<String> wordsSortingCertainLenght(List<String> words, int searchTerm)
    {
        List<String> sortedWords = new List<String>();
        foreach (String word in words)
        {
            if (word.Length == searchTerm)
            {
                sortedWords.Add(word);
            }
        }

        return sortedWords;
    }
}

