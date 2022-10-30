class Pet
{
    // Поля.
    private string name;
    private int age;
    private string kind;
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
    public string Kind
    {
        get => this.kind;
        set => this.kind = value;
    }

    // Конструктори.
    public Pet(string name, int age, string kind)
    { this.Name = name; this.Age = age; this.Kind = kind; }

    // Методи. 
    public override string ToString() => $"{this.Name} {this.Age} {this.Kind}";
}