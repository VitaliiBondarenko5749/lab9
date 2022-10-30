using System.Net.NetworkInformation;

class Person : IComparable<Person>
{
    // Поля.
    string name;
    int age;
    string town;

    // Властивості.
    public string Name { get => this.name; set => this.name = value; }
    public int Age { get => this.age; set => this.age = value; }
    public string Town { get => this.town; set => this.town = value; }

    // Конструктори.
    public Person(string name, int age, string town)
    { this.Name = name; this.Age = age; this.Town = town; }

    //Методи
    public int CompareTo(Person p)
    {
        int compare = Name.CompareTo(p.Name);

        if(compare == 0)
        {
            compare = Age.CompareTo(p.Age);
            
            if(compare == 0)
                compare = Town.CompareTo(p.Town);
        }

        return compare;
    }

}