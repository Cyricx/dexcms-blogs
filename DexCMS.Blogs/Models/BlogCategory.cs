using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.Blogs.Models
{
    public class BlogCategory
    {
        [Key]
        public int BlogCategoryID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }

    }
}
