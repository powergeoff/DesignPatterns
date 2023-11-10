

public class PancakeHouseMenuIterator : IIterator
{
    private List<MenuItem> _items;
    private int position = 0;

    public PancakeHouseMenuIterator(List<MenuItem> items)
    {
        _items = items;
    }
    public bool HasNext()
    {
        return position <= _items.Count - 1;
    }

    public object Next()
    {
        MenuItem item = _items[position];
        position++;
        return item;
    }
}
