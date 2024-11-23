using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Username { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        public string CustomFields { get; set; }

        public bool Active { get; set; }

        public int Company_Id { get; set; }

        // Navegación
        [ForeignKey("Company_Id")]
        public Company Company { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
