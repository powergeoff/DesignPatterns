/*
The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. 
The abstract modifier can be used with classes, methods, properties, indexers, and events. 
Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, 
not instantiated on its own. Members marked as abstract must be implemented by non-abstract classes 
that derive from the abstract class.
*/

public abstract class AbstractClass
{
    //no instantiation
    //CAN NEVER be SEALED
    //sealed is the opposite of abstract
    //abstract must be inherited
    //sealed stops further inheritance
    //abstract method has no implementation - it must be overridden
    //implicitly virtual

    public static string Reverse(string target)
    {

        if (String.IsNullOrEmpty(target))
        {
            return null;
        }

        var ret = new System.Text.StringBuilder("", target.Length);

        for (int i = target.Length - 1; i >= 0; i--)
        {
            ret.Append(target[i]);
        }
        return ret.ToString();
    }

    public static bool IsPalindrome(string target)
    {
        if (String.IsNullOrEmpty(target))
        {
            return false;
        }

        var ret = true;
        //two pointers
        var start = 0;
        var end = target.Length - 1;

        while (start < end && target[start] != target[end])
        {
            if (target[start] != target[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return ret;
    }
}

public class NewClass
{
    //below is a problem - abstract method must belong to an abstract class
    //public abstract void DoStuff();
}