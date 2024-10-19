namespace First_API.DataAccess.Contracts_DataAccess
{
    public interface IBaseRepository<TEntity>
    {
        //CRUD operation
        IEnumerable<TEntity> GetAll();
        TEntity FindById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
