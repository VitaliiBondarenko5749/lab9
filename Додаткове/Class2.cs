using System.Collections;
class Enumerator : IEnumerable
{
    object[] types;
    public Enumerator(object[] it) => this.types = it;

    IEnumerator IEnumerable.GetEnumerator() => this.types.GetEnumerator();
    public IEnumerator GetEnumerator => this.types.GetEnumerator();
}