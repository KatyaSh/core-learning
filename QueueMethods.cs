public class QueueMethods
{
    public static Queue<int> SwapFirstAndLastMethod(Queue<int> queue)
    {
        var first = queue.Dequeue();
        List<int> elements = new List<int>();

        while (queue.Count > 1)
        {
            elements.Add(queue.Dequeue());
        }

        var last = queue.Dequeue();
        queue.Enqueue(last);

        foreach (var item in elements)
        {
            queue.Enqueue(item);
        }

        queue.Enqueue(first);
        return queue;
    }

    public static Queue<int> ReverseQueue(Queue<int> queue)
    {
        List<int> list = queue.ToList();

        list.Reverse();

        return new Queue<int>(list);
    }
}

