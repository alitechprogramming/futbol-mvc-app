
using AplicacionMVC.Models.Entities;

namespace AplicacionMVC.Models.Repository
{
    public interface IRepository
    {
        public IEnumerable<Notice> Get();
        public Notice Get(int id);        
        public void Update(Notice notice);
        public void Delete(int ID);

        public void Save();
    }
}
