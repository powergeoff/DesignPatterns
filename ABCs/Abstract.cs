/*
The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. 
The abstract modifier can be used with classes, methods, properties, indexers, and events. 
Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, 
not instantiated on its own. Members marked as abstract must be implemented by non-abstract classes 
that derive from the abstract class.
*/

public abstract class AbstractClass{
    //no instantiation
    //CAN NEVER be SEALED
        //sealed is the opposite of abstract
        //abstract must be inherited
        //sealed stops further inheritance
    //abstract method has no implementation - it must be overridden
        //implicitly virtual
}

public class NewClass{
    //below is a problem - abstract method must belong to an abstract class
    //public abstract void DoStuff();
}