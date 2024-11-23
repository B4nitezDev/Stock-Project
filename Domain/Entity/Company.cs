using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)] 
        public string Name { get; set; }

        public string CustomFields { get; set; }
        public string Description { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Config> Configs { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
