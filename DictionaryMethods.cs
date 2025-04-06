public class DictionaryMethods
{
    public static Dictionary<int, string> SortAndMergeLists(List<int> intList, List<string> stringList)
    {
        Dictionary<int, string> mergedDictionary = new Dictionary<int, string>();
        intList.Sort();
        stringList.Sort();
        stringList.Reverse();        

        for (int i = 0; i < intList.Count; i++)
        {
            mergedDictionary.Add(intList[i], stringList[i]);
        }

        return mergedDictionary;
    }
}
