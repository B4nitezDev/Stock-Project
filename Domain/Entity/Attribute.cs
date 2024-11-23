using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Attribute
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Attribute_Name { get; set; }

        [MaxLength(255)]
        public string Sub_Attribute { get; set; }

        public int Product_Id { get; set; }

        // Navegación
        [ForeignKey("Product_Id")]
        public Product Product { get; set; }
    }
}
