using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Abstract;
public interface IGenericDal<T> where T : class
{
   
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T GetByID(int id);
    List<T> GetListAll();   
}
