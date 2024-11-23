using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Config
    {
        public int Id { get; set; }

        public string CustomFields { get; set; }

        [MaxLength(255)]
        public string Value { get; set; }

        [MaxLength(255)]
        public string KEY { get; set; }

        public int Company_Id { get; set; }

        // Navegación
        [ForeignKey("Company_Id")]
        public Company Company { get; set; }
    }
}
