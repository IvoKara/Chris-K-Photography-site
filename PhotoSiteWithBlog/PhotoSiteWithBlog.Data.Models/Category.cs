using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoSiteWithBlog.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Posts = new List<Post>();
        }

        public virtual int Id
        { get; set; }

        [Required]
        public virtual string Name
        { get; set; }

        public virtual string UrlSlug
        { get; set; }

        public virtual string Description
        { get; set; }

        public virtual ICollection<Post> Posts
        { get; set; }
    }
}
