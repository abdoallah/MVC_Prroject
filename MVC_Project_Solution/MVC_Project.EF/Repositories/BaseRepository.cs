using Microsoft.EntityFrameworkCore;
using MVC_Project.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
