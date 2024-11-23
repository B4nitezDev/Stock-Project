using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int Stock { get; set; }

        public string Image { get; set; }

        [Required]
        public string Barcode { get; set; }

        public int Stock_Threshold_Alert { get; set; }

        public int Company_Id { get; set; }

        // Navegación
        [ForeignKey("Company_Id")]
        public Company Company { get; set; }

        public ICollection<History> Histories { get; set; }
        public ICollection<Attribute> Attributes { get; set; }
        public ICollection<Alert> Alerts { get; set; }
    }
}
