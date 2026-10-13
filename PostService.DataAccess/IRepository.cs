using PostService.Models;
namespace PostService.DataAccess;
public interface IRepository<T> where T : Model
{
    void Add(T entity);
    T? GetById(int id);
    IEnumerable<T> GetAll();
    void Update(T entity);
    void Delete(int id);
}