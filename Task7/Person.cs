class Person : IComparable<Person>
{
    // Поля. 
    private string name;
    private int age;
    private char[] ch = { '~', '`', '₴', '!', '@', '"', '#', '№', '$', ';', '%',
        '^', ':', '&', '?', '*', '(', ')', '-', '+', '/', '|' };

    // Властивості.
    public string Name
    {
        get => this.name;
        set
        {
            if (value.Length < 1 || value.Length > 50)
                throw new ArgumentException("Invalid length of the name!");

            for (int i = 0; i < ch.Length; ++i)
                if (value.Contains(ch[i]))
                    throw new ArgumentException("Invalid name!");

            this.name = value;
        }
    }
    public int Age
    {
        get => this.age;
        set
        {
            if (value < 1 || value > 100)
                throw new ArgumentException("Invalid age!");
            else
                this.age = value;
        }
    }

    //Конструктори.
    public Person(string name, int age) { this.Name = name; this.Age = age; }

    // Методи.
    public override string ToString() => (this.Name + " " + this.Age);

    public int CompareTo(Person other) => GetHashCode().CompareTo(other.GetHashCode());

    public override int GetHashCode() => (Name.GetHashCode() * 397) ^ Age;
    
    public override bool Equals(object? obj)
    {
        if (obj is Person other)
            return (Name == other.Name && Age == other.Age);

        return false;
    }
}
