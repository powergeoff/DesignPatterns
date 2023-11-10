using System.Collections.Immutable;
//WRONG WRONG WRONG THIS IS UNIMPLEMENTED
public class CompositeIterator : IIterator
{
    Stack<IIterator> stack = new Stack<IIterator>();

    public CompositeIterator(IIterator iterator)
    {
        stack.Push(iterator);
    }
    public bool HasNext()
    {
        if (stack.Count == 0)
        {
            return false;
        }
        else
        {
            IIterator iterator = (IIterator) stack.Peek();
            if(!iterator.HasNext())
            {
                stack.Pop();
                return HasNext();
            }
            else
            {
                return true;
            }
        }
    }

    public object? Next()
    {
        if(HasNext()) 
        {
            IIterator iterator = (IIterator) stack.Peek();
            MenuComponent? component = (MenuComponent?) iterator.Next();
            if (component is Menu)
            {
                //stack.Push(component.CreateIterator());
            }
            return component;
        }
        else 
        {
            return null;
        }
    }
}
