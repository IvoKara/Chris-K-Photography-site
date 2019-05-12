using PhotoSiteWithBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhotoSiteWithBlog.ViewModels
{
    public class CreatePostViewModel
    {
        public virtual string Title
        { get; set; }

        public virtual string ShortDescription
        { get; set; }

        public virtual string Content
        { get; set; }
    }
}
