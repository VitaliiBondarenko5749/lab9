class NameComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int comparer = x.Name.Length.CompareTo(y.Name.Length);

        if(comparer == 0)
        {
            comparer = x.Name.CompareTo(y.Name);
        }

        return comparer;
    }
}