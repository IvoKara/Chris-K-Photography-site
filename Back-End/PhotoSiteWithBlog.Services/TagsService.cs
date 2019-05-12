using PhotoSiteWithBlog.Data;
using PhotoSiteWithBlog.Data.Models;
using PhotoSiteWithBlog.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoSiteWithBlog.Services
{
    class TagsService : ITagsService
    {
        private PhotoSiteWithBlogDbContext context;

        public TagsService(PhotoSiteWithBlogDbContext context)
        {
            this.context = context;
        } 
        public int CreateTag(string name)
        {
            Tag tag = new Tag() { Name = name };
            this.context.Tags.Add(tag);
            this.context.SaveChanges();

            return tag.Id;
        }
    }
}
