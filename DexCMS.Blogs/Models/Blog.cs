using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DexCMS.Base.Models;

namespace DexCMS.Blogs.Models
{
    public class Blog
    {
        [Key, ForeignKey("PageContent")]
        public int BlogID { get; set; }

        [Required]
        public int BlogCategoryID { get; set; }

        [Required]
        public int BlogStatusID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public bool IsPublic { get; set; }

        //Relationships
        public virtual BlogCategory BlogCategory { get; set; }
        public virtual ICollection<BlogTag> BlogTags { get; set; }
        public virtual PageContent PageContent { get; set; }
        public virtual BlogStatus BlogStatus { get; set; }

    }
}
