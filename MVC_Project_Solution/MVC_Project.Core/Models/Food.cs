using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "money")]

        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [ForeignKey("Category")]
        public int Category_Id { get; set; }
        public Category Category { get; set; }




    }
}
