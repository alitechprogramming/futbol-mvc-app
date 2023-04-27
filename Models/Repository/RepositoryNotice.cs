using AplicacionMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AplicacionMVC.Models.Repository
{
    public class RespositoryNotice : IRepository
    {
        private readonly FootballAppContext _footballAppContext;

        public RespositoryNotice(FootballAppContext footballAppContext)
        {
            _footballAppContext = footballAppContext;
        }
        public void Delete(int id)
        {
            var objectToDelete = _footballAppContext.Notices.Find(id);
            _footballAppContext.Notices.Remove(objectToDelete);
        }

        public IEnumerable<Notice> Get() => _footballAppContext.Notices;

        public Notice Get(int id) => _footballAppContext.Notices.Find(id);

        public void Update(Notice notice)
        {
            _footballAppContext.Entry(notice).State = EntityState.Modified;
        }

        public void Save()
        {
            _footballAppContext.SaveChanges();
        }

       
    }
}
