namespace labFrom7.Iterator;

public class ConcreticoIteratore<T>:IIterator<T>
{
    private List<T> _laColectia;
    private int _indexuCurrento=0;

    public ConcreticoIteratore(List<T> laColectia)
    {
        _laColectia = laColectia;
    }
    
    public T Current => _laColectia[_indexuCurrento];

    public bool MoveNext()
    {
        if (_indexuCurrento >= _laColectia.Count - 1)
        {
            return false;
        }
        _indexuCurrento++;
        return true;
        
    }

    public bool MovePrevious()
    {
        if (_indexuCurrento <= 0)
        {
            return false;
        }
        _indexuCurrento++;
        return true;
    }

    public void Reset()
    {
        _indexuCurrento = 0;
    }
    
}