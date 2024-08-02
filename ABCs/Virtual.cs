public class VirtualMethodClass
{
    /*
    define some logic in a parent class that can be overridden in a child class
    */
    public virtual double Area(int x, int y)
    {
        return x * y;
    }
}

public class InheritVirtual : VirtualMethodClass
{

}

public class InheritVirtual2 : VirtualMethodClass
{
    public override double Area(int x, int y)
    {
        return x * y;
    }
}

//virtual vs abstract
//virtual method provides an implementation that a child class can override
//abstract method has no implementation and MUST be overridden by child class