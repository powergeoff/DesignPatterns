

public class DinerMenuIterator : IIterator
{
    private MenuItem[] _items;
    private int position = 0;

    public DinerMenuIterator(MenuItem[] items)
    {
        _items = items;
    }
    public bool HasNext()
    {
        return position <= _items.Count() - 1;
    }

    public Object Next()
    {
        MenuItem item = _items[position];
        position++;
        return item;
    }
}