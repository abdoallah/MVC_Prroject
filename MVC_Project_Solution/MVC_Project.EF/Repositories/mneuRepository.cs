using MVC_Project.Core.Interfaces;
using MVC_Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.EF.Repositories
{
    public class mneuRepository : BaseRepository<menu>, Imenu
    {
        private readonly ApplicationDbContext _Context;
        public mneuRepository(ApplicationDbContext Context):base (Context)
        {

        }
        public IEnumerable<menu> menu_getall()
        {
          throw new NotImplementedException();
        }
    }
}
