using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Category_Name { get; set; }

        public int? Parent_Category { get; set; }

        public int Company_Id { get; set; }

        public string CustomFields { get; set; }

        [ForeignKey("Parent_Category")]
        public Category ParentCategory { get; set; }

        public ICollection<Category> SubCategories { get; set; }

        [ForeignKey("Company_Id")]
        public Company Company { get; set; }
    }
}
