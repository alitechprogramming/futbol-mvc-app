using Microsoft.EntityFrameworkCore;

namespace AplicacionMVC.Models.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly FootballAppContext _footballAppContext;
        private DbSet<TEntity> _dbSet;
        public Repository(FootballAppContext footballAppContext)
        {
            _footballAppContext = footballAppContext;
            _dbSet = _footballAppContext.Set<TEntity>();
        }

        public void Add(TEntity data) => _dbSet.Add(data);

        public void Delete(int id)
        {
            var objectToDelete = _dbSet.Find(id);
            _dbSet.Remove(objectToDelete);
        }

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity Get(int id) => _dbSet.Find(id);

        public void Save()
        {
            _footballAppContext.SaveChanges();
        }

        public void Update(TEntity data)
        {
            _dbSet.Entry(data).State = EntityState.Modified;
        }
    }
}
