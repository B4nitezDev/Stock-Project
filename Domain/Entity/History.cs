using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class History
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Action { get; set; }

        public int Quantity { get; set; }

        public DateTime Created_At { get; set; }

        public int Product_Id { get; set; }

        // Navegación
        [ForeignKey("Product_Id")]
        public Product Product { get; set; }
    }
}
