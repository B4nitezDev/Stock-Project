using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Role
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Role_Name { get; set; }

        public string CustomFields { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        // Navegación
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
