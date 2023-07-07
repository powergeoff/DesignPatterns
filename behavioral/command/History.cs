public class History<T>{
    private List<T> _historyItems;

    public History()
    {
        _historyItems = new List<T>();
    }

    public void Push(T item){
        _historyItems.Add(item);
    }

    public T Pop(){
        return _historyItems[_historyItems.Count - 1];
    }
}