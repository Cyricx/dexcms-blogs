using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DexCMS.Blogs.Models
{
    public class BlogStatus
    {
        [Key]
        public int BlogStatusID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }

    }
}
