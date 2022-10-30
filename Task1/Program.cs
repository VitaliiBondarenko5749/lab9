class Program
{
    static int count = 0;
    static void Main(string[] args)
    {
        ListyIterator<string> listy_iterator;

        while (true)
        {
            try
            {
                ++count;
                if (count == 101)
                    return;

                List<string> input = new(Console.ReadLine().Split(' '));

                if (input[0] == "END")
                    break;

                if (input[0] == "Create")
                {
                    if (input.Count > 1)
                    {
                        input.RemoveAt(0);

                        listy_iterator = new ListyIterator<string>(input);
                        Use_ListyIterator(ref listy_iterator);
                        break;
                    }
                    else
                        throw new InvalidOperationException("Invalid Operation!");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.ReadKey();
    }

    static void Use_ListyIterator<K>(ref ListyIterator<K> l)
    {
        string input;

        while((input = Console.ReadLine()) != "END")
        {
            ++count;

            if (count == 101)
                return;
            try
            {
                if (input == "Create")
                    throw new InvalidOperationException("Invalid Operation!");
                if (input == "HasNext")
                    Console.WriteLine(l.HasNext());
                if (input == "Print")
                    l.Print();
                if (input == "Move")
                    Console.WriteLine(l.Move());
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}