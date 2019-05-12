using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoSiteWithBlog.Data.Models
{
    public class Post
    {
        public Post()
        {
            this.PostedOn = DateTime.UtcNow;
            this.PostTags = new List<PostTag>();
        }

        public virtual int Id
        { get; set; }

        [Required]
        public virtual string Title
        { get; set; }

        public virtual string  ShortDescription
        { get; set; }

        public virtual string Content
        { get; set; }

        public virtual string Meta
        { get; set; }

        public virtual string UrlSlug
        { get; set; }

        public virtual bool Published
        { get; set; }

        [DataType(DataType.Date)]
        public virtual DateTime PostedOn
        { get; set; }

        [DataType(DataType.Date)]
        public virtual DateTime? Modified
        { get; set; }

        [StringLength(60)]
        public virtual Category Category
        { get; set; }

        public virtual ICollection<PostTag> PostTags
        { get; set; }
    }
}
