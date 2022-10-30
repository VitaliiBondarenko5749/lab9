class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        while (true)
        {
            try
            {
                List<string> input = new(Console.ReadLine().Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries));

                if (input[0] == "END")
                {
                    foreach (var st in stack)
                        Console.WriteLine(st);

                    break;
                }

                if (input[0] == "Push")
                {
                    input.RemoveAt(0);

                    foreach (string s in input)
                        stack.Push(int.Parse(s));
                }
                if (input[0] == "Pop")
                    stack.Pop();
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        Console.ReadKey();
    }
}