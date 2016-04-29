namespace DAL.Interfaces
{
    public interface IRepository<T> where T: class
    {
        //Repository CRUD interface.

        void Add(T obj);

        T GetAll();
        T Get(int id);

        void Update(T obj);

        void Delete(int id);
        void Delete(T obj);
    }
}