using System;
using System.ComponentModel.DataAnnotations;

namespace PhotoSiteWithBlog.ViewModels
{
    public class CreateCategoryViewModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }

}
