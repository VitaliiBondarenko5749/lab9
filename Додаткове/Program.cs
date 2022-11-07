using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        object[] iteration = new object[8];
        int pos = 0;
        Type t = typeof(MyIteration);

        foreach(FieldInfo field in t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
        {
            if(field.IsPrivate)
                iteration[pos] = field.Name;
                ++pos;
        }

        Enumerator en = new(iteration);

        Console.Write(en);
    }
}