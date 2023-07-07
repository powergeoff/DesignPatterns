namespace Behavioral.Observer;

public class DataSource: Subject {
    public int Value { get; set; }

    public void SetValue(int value){
        Value = value;
        Notify();
    }
}