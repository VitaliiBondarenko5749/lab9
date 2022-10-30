class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        try
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "END")
                    break;
                try
                {
                    bool tryparse = Int32.TryParse(input[1], out int num);

                    if (tryparse == true)
                    {
                        if (num < 2 || num > 100)
                            throw new ArgumentOutOfRangeException("Invalid age!");
                    }
                    else
                        break;

                    if (input.Length == 3)
                        people.Add(new(input[0], int.Parse(input[1]), input[2]));
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Person person = people[int.Parse(Console.ReadLine()) - 1];

            int count = people.Count(p => p.CompareTo(person) == 0);

            if (count <= 1)
                throw new Exception("No matches");
            else
                Console.WriteLine(count + " " + (people.Count - count) + " " + people.Count + "\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}