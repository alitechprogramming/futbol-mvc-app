
using AplicacionMVC.Models.Entities;

namespace AplicacionMVC.Models.Repository
{
    public interface IRepository<TEntity>
    {
        public void Add(TEntity data);
        public IEnumerable<TEntity> Get();
        public TEntity Get(int id);        
        public void Update(TEntity data);
        public void Delete(int id);

        public void Save();
    }
}
