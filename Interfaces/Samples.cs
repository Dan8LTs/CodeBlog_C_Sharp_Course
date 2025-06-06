using System.Collections;

public interface IDisposable
{
    void Dispose();
}
public interface IEnumerable
{
    IEnumerator GetEnumerator();
}
public interface IEnumerable<T> : IEnumerable
{
    IEnumerator<T> GetEnumerator();
}

public interface ICollection<T> : IEnumerable<T>, IEnumerable
{
    void Add(T item);
    void Clear();
    bool Contains(T item);
    void CopyTo(T[] array, int arrayIndex);
    bool Remove(T item);
    int Count { get; }
    bool IsReadOnly { get; }
}