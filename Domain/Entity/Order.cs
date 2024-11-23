using Domain.Enums.Orders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Order_Number { get; set; }

        [MaxLength(50)]
        public OrderType Order_Type { get; set; }

        [MaxLength(50)]
        public OrderStatus CurrentStatus { get; set; }

        public int Company_Id { get; set; }

        public string CustomFields { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime Updated_At { get; set; }

        [ForeignKey("Company_Id")]
        public Company Company { get; set; }
    }
}
