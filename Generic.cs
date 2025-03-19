public class Generic<T> where T : Human
{
    private T[] _array = Array.Empty<T>();
    public T this[int index]
    {
        get { return _array[index]; }
        set { _array[index] = value; }
    }

    public int ArrayLength()
    {
        return _array.Length;
    }

    public void AddElement(T value)
    {
        var newArray = new T[_array.Length + 1];
        for (int i = 0; i < _array.Length; i++)
        {
            newArray[i] = _array[i];
        }
        newArray[_array.Length] = value;
        _array = newArray;
    }

    public void RemoveElement(int index)
    {
        var arrayRemove = new T[_array.Length - 1];
        for (int i = 0; i < index; i++)
        {
            arrayRemove[i] = _array[i];
        }

        for (int i = index + 1; i < _array.Length; i++)
        {
            arrayRemove[i - 1] = _array[i];
        }

        _array = arrayRemove;
    }

    public void ToString()
    {
        var countWoman = 0;
        var countMan = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] is Woman)
            {
                countWoman++;
            }

            if (_array[i] is Man)
            {
                countMan++;
            }

            Console.WriteLine($"FirstName: {_array[i].FirstName}, LastName: {_array[i].LastName}");
        }

        if (countWoman == _array.Length)
        {
            Console.WriteLine("There’re only women");
        }

        if (countMan == _array.Length)
        {
            Console.WriteLine("There’re only men");
        }
    }
}

