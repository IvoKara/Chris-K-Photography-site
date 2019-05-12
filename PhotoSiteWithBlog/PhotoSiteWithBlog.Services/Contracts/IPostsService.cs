using Microsoft.EntityFrameworkCore;
using PhotoSiteWithBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSiteWithBlog.Services.Contracts
{
    public interface IPostsService<T>
    {
        int CreatePost(string title, string category,
            string content, string shortDescription);

        DbSet<Post> ListAll { get; }

        Task<Post> EditPost(int id, string title, string category,
            string shortDescription, string content);

        Task<Post> DetailPost(int? id);

        Task<Post> DeletePost(int id);
    }
}
