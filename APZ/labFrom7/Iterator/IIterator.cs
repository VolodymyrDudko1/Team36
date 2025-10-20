namespace labFrom7.Iterator;

public interface IIterator<T>
{
    T Current { get; }
    bool MoveNext();
    bool MovePrevious();
    void Reset();
}