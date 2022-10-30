class Program
{
    static void Main(string[] args)
    {
        SortedSet<Person> sortedSet = new SortedSet<Person>();
        HashSet<Person> hashSet = new HashSet<Person>();

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n && i < 100; ++i)
        {
            string[] input = Console.ReadLine().Split(' ');

            Person person = new Person(input[0], int.Parse(input[1]));

            sortedSet.Add(person);
            hashSet.Add(person);
        }

        Console.WriteLine(sortedSet.Count + "\n" + hashSet.Count);

        Console.ReadKey();
    }
}