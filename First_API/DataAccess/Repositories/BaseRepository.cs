
using First_API.DataAccess.Contracts_DataAccess;
using Microsoft.EntityFrameworkCore;

namespace First_API.DataAccess.Repositories
{
    //1
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        //2 DB
        protected readonly CustomDbContext _db;
        protected readonly DbSet<TEntity> _dbSet;
        public BaseRepository(CustomDbContext db) { 
            _db = db;
            _dbSet = db.Set<TEntity>(); 
        
        }
        // imp CRUD
        public void Delete (int id)
        {
            var entity = FindById(id);
            _dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.AsEnumerable();   
        }

        public TEntity FindById(int id)
        {
            return _dbSet.Find(id);    
            
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Entry(entity).State = EntityState.Modified;
           // _dbSet.Update(entity);
        }
    }
}
