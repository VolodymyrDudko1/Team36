namespace labFrom7.Iterator;

public class ConcreticoAgregate<T>:IAggravate<T>
{
    private readonly List<T> _laCollectia = new List<T>();

    public void Add(T item)
    {
        _laCollectia.Add(item);
    }

    public IIterator<T> GetIterator()
    {
        return new ConcreticoIteratore<T>(_laCollectia);
    }
}