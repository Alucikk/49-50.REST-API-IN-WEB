using PostService.Models;
namespace PostService.DataAccess;
public class GenericRepository<T> : IRepository<T> where T : Model
{
    private static readonly List<T> _items = new List<T>();
    public void Add(T entity)
    {
        _items.Add(entity);
    }
    public T? GetById(int id)
    {
        foreach (var item in _items)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
    public IEnumerable<T> GetAll()
    {
        return _items;
    }
    public void Update(T entity)
    {
        var existing = GetById(entity.Id);
        if (existing != null)
        {
            var index = _items.IndexOf(existing);
            _items[index] = entity;
        }
    }
    public void Delete(int id)
    {
        var item = GetById(id);
        if (item != null)
        {
            _items.Remove(item);
        }
    }
}