public class VirtualMethodClass{
    /*
    define some logic in a parent class that can be overridden in a child class
    */
    public virtual double Area(int x, int y)
    {
        return x * y;
    }
}

public class InheritVirtual: VirtualMethodClass{

}

public class InheritVirtual2: VirtualMethodClass{
    public override double Area(int x, int y)
    {
        return x * y;
    }
}