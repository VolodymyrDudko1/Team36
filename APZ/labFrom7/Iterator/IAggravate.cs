namespace labFrom7.Iterator;

public interface IAggravate<T>
{
    IIterator<T> GetIterator();
}