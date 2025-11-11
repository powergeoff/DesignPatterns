public interface Repository<T, K, Y>
{
    List<T> read();

    List<Y> readAllAsAnotherType();

    T readById(K id);
    T create(T entity);
    T update(T entity);
    T delete(T entity);
}