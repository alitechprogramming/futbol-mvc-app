
using AplicacionMVC.Models.Entities;

namespace AplicacionMVC.Models.Repository
{
    public interface IRepository<TEntity>
    {
        public IEnumerable<TEntity> Get();
        public TEntity Get(int id);        
        public void Update(TEntity notice);
        public void Delete(int ID);

        public void Save();
    }
}
