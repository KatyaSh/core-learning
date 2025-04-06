public class AddToLinkedListMethod
{
    public static LinkedList<int> AddedValuesToList(LinkedList<int> initialValuesList, int firstItem, int secondItem)
    {
        var currentNode = initialValuesList.First;

        while (currentNode != null)
        {
            if (currentNode.Value == firstItem)
            {
                initialValuesList.AddAfter(currentNode, secondItem);
            }

            currentNode = currentNode.Next;
        }

        return initialValuesList;
    }
}
