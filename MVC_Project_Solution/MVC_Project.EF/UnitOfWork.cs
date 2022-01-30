using MVC_Project.Core.Interfaces;
using MVC_Project.Core.Models;
using MVC_Project.EF.Repositories;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.EF
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly RestaurantService _Context;

        //public IBaseRepository<menu> menus { get; private set; }
        //public IBaseRepository<gust> gusts { get; private set; }
        public UnitOfWork(RestaurantService Context)
        {
            _Context=Context;
           


        }
        public int complete()
        {
            return _Context.SaveChanges();
        }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
