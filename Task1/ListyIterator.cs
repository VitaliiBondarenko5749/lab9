using System.Collections;

public class ListyIterator<T>
{
    // Поля.
    private List<T> list;
    private int index;

    // Конструктор.
    public ListyIterator(IEnumerable<T> elements)
    {
        this.list = new List<T>(elements);
        this.index = 0;
    }

    // Методи.
    public bool HasNext()
    {
        if (index + 1 < list.Count)
            return true;

        return false;
    }

    public bool Move()
    {
        if (HasNext() == false)
            return false;
        
        index++;
        return true;
    }

    public void Print()
    {
        if (list.Count == 0)
            throw new InvalidOperationException("Invalid Operation!");
        
        Console.WriteLine(list[index]);
    }
}