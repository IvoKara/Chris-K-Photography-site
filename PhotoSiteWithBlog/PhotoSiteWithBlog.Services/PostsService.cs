using Microsoft.EntityFrameworkCore;
using PhotoSiteWithBlog.Data;
using PhotoSiteWithBlog.Data.Models;
using PhotoSiteWithBlog.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSiteWithBlog.Services
{
    public class PostsService : IPostsService<Post>
    {
        private PhotoSiteWithBlogDbContext context;

        public PostsService(PhotoSiteWithBlogDbContext context)
        {
            this.context = context;
        }

        public DbSet<Post> ListAll { get => context.Posts; }

        public int CreatePost(
            string title,
            string category = "",
            string content = "",
            string shortDescription = "")
        {
            Post postNew = new Post()
            {
                Title = title,
                Content = content,
                ShortDescription = shortDescription,
                Published = true,
                PostedOn = new DateTime(),
                Modified = new DateTime(),
                Category = new Category()
            };
            postNew.Published = true;
            postNew.PostedOn = DateTime.Now;
            postNew.Modified = postNew.PostedOn;
            postNew.Category.Name = category;
            this.context.Posts.Add(postNew);
            this.context.SaveChanges();
            
            return postNew.Id;
        }

        public async Task<Post> DetailPost(int? id)
        {
            return await this.context.Posts
               .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Post> EditPost(int id, string title, string category,
             string shortDescription, string content)
        {
            var postToEdit = await this.DetailPost(id);
            postToEdit.Title = title;
            postToEdit.Content = content;
            postToEdit.ShortDescription = shortDescription;
            postToEdit.Modified = DateTime.Now;
            this.context.Posts.Update(postToEdit);
            this.context.SaveChanges();
            return postToEdit;
        }

        public async Task<Post> DeletePost(int id)
        {
            var postToDelete = await context.Posts.FindAsync(id);
            this.context.Posts.Remove(postToDelete);
            await this.context.SaveChangesAsync();
            return postToDelete;
        }
    }
}
