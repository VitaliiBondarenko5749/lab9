class Program
{
    static void Main(string[] args)
    {
        SortedSet<Person> name = new SortedSet<Person>(new NameComparer());
        SortedSet<Person> age = new SortedSet<Person>(new AgeComparer());

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n && i < 100; ++i)
        {
            string[] input = Console.ReadLine().Split(' ');

            Person person = new(input[0], int.Parse(input[1]));

            name.Add(person);
            age.Add(person);
        }

        Console.WriteLine();

        foreach (Person s in name)
            Console.WriteLine(s);

        Console.WriteLine(); 
        
        foreach (Person s in age)
            Console.WriteLine(s);
    }
}