using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Core.Models
{
    public class menu
    {
        //this is example
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
      
       public menu menus { get; set; }
        
        public int menueId { get; set; }
        


    }
}
