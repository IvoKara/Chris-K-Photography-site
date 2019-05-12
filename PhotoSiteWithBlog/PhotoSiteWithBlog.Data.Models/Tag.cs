using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoSiteWithBlog.Data.Models
{
    public class Tag
    {
        public Tag()
        {
            this.PostTags = new List<PostTag>();
        }

        public virtual int Id
        { get; set; }

        [Required]
        public virtual string Name
        { get; set; }

        public virtual string UrlSlug
        { get; set; }

        public virtual ICollection<PostTag> PostTags
        { get; set; }
    }
}
