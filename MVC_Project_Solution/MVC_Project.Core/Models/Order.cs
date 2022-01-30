using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Order
    {
        public int Id { get; set; }
        [DataType(DataType.DateTime)]
        public string DateTime { get; set; }
        [Column(TypeName = "money")]

        public decimal Price { get; set; }
        [ForeignKey("Customer")]
        public int Customer_Id { get; set; }
        [ForeignKey("Admin")]
        public int Admin_Id { get; set; }
        [ForeignKey("Payment")]
        public int Payment_Id { get; set; }
        public Customer Customer { get; set; }
        public Admin Admin { get; set; }
        public Payment Payment { get; set; }




    }
}
