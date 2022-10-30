class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);
        List<int> odd_numbers = new List<int>();
        List<int> even_numbers = new List<int>();

        for(int i = 0; i < input.Length; ++i)
        {
            if (int.Parse(input[i]) % 2 != 0)
                odd_numbers.Add(int.Parse(input[i]));
            if (int.Parse(input[i]) % 2 == 0)
                even_numbers.Add(int.Parse(input[i]));
        }

        even_numbers.Reverse();

        odd_numbers.AddRange(even_numbers);

        Lake lake = new(odd_numbers);

        even_numbers.Clear();
        odd_numbers.Clear();

        foreach(var l in lake)
           Console.Write(l + " ");

        Console.WriteLine();
        Console.ReadKey();
    }
}