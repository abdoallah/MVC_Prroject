using MVC_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Core.Interfaces
{
    public interface Imenu:IBaseRepository<menu>
    {
       //special method for menu model only 
        IEnumerable<menu> menu_getall();
    }
}
