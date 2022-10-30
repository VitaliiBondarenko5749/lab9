using System.Collections;
using System.Runtime.InteropServices;

class Stack<T> : IEnumerable<T>
{
    // Поля.
    private T[] arr;
    private int index;

    // Конструктори.
    public Stack(int size = 4) { this.arr = new T[size]; this.index = 0; }

    // Методи.
    public T Pop()
    {
        if (index == 0)
            throw new IndexOutOfRangeException("No elements");

        return arr[--index];
    }

    public void Push(T el)
    {
        if(index == arr.Length)
        {
            T[] newArray = new T[arr.Length*2];

            Array.Copy(arr, newArray, arr.Length);

            arr = newArray;
        }

        arr[index++] = el;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for(int i = index-1; i>=0; --i)
            yield return arr[i];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}