using PetsLocalizer2.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PetsLocalizer2.Data.Repositorio
{
    public interface IBaseRepository <T> where T: class
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        T Get();
        T Get(int id);
        T Get(Expression<Func<T, bool>> expression);
        List<T> All();
        bool Save();
    }

    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly PetsLocalizer2Context DbContext;
        protected DbSet<T> _set;

        public BaseRepository()
        {
            DbContext = new PetsLocalizer2Context();
            _set = DbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _set.Add(entity);
        }

        public List<T> All()
        {
            return _set.ToList();
        }

        public void Delete(int id)
        {
            var entidad = Get(id);
            _set.Remove(entidad);
        }

        public T Get()
        {
            return _set.FirstOrDefault();
        }

        public T Get(int id)
        {
            return _set.Find(id);
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _set.FirstOrDefault(expression);
        }

        public void Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        public bool Save()
        {
            try
            {
                return DbContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
