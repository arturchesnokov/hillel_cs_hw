using System.Collections;

namespace HW3;

public delegate void OnExpandedDelegate(string message);

public class CustomClass<T> : IEnumerable<T>
{
    private T[] _data;
    private const int DefaultSize = 4;

    private int Count { get; set; }

    public event OnExpandedDelegate OnExpandedEvent;

    public CustomClass()
    {
        _data = new T[DefaultSize];
    }

    public void Add(T element)
    {
        if (_data.Length == Count)
        {
            T[] newArray = new T[Count * 2];
            Array.Copy(_data, newArray, Count);
            _data = newArray;

            OnExpandedEvent.Invoke($"Array has been enlarged to {Count * 2}");
        }

        _data[Count++] = element;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();
            return _data[index];
        }
        set
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();
            _data[index] = value;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in _data)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}