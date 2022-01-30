using MVC_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        //IBaseRepository<menu> menus { get; }
        //IBaseRepository<gust> gusts { get; }
        int Complete();
        
    }
}
