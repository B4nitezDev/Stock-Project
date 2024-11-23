using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Permission
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Permission_Name { get; set; }

        public string CustomFields { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        // Navegación
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
