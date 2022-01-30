using MVC_Project.Core.Models;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Core.Interfaces
{
    public interface Imenu:IBaseRepository<Food>
    {
       //special method for menu model only 
        IEnumerable<Food> menu_getall();
    }
}
