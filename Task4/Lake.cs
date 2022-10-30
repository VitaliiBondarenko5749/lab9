using System.Collections;

class Lake : IEnumerable
{
    // Поля.
    List<int> list;

    // Конструктори.
    public Lake(IEnumerable<int> elements)
    {
        this.list = new List<int>(elements);
    }

    //Методи
    IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < list.Count; ++i)
        {
            if (list[i] % 2 != 0)
                Console.ForegroundColor = ConsoleColor.Yellow;
            if (list[i] % 2 == 0)
                Console.ForegroundColor = ConsoleColor.Green;

            yield return list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}