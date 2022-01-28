using Microsoft.EntityFrameworkCore;
using MVC_Project.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected ApplicationDbContext _Context;
        public BaseRepository(ApplicationDbContext Context)
        {
            _Context = Context;
        }
        public T GetById(int id)
        {

            return _Context.Set<T>().Find(id);
        }
        public T Add(T entity)
        {
            _Context.Set<T>().Add(entity);
            _Context.SaveChanges();
            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            _Context.Set<T>().AddRange(entities);
            _Context.SaveChanges();
            return entities;
        }

        //return matched item not by id by name for example  
        public T Find(Expression<Func<T, bool>> Criteria)
        {

            return _Context.Set<T>().SingleOrDefault(Criteria);
        }




        //return all items in selected model of <T>
        public IEnumerable<T> GetAll()
        {
            return _Context.Set<T>().ToList();
        }
       

        //update method
        public T Update(T entity)
        {
            _Context.Update(entity);
            return entity;

        }
        //delete method
        public void Delete(T entity)
        {
            _Context.Set<T>().Remove(entity);
        }
        //attatch method
        public void Attatch(T entity)
        {
            _Context.Set<T>().Attach(entity);
        }
        //count method
        public int Count()
        {
            return _Context.Set<T>().Count();
        }

    }
}
