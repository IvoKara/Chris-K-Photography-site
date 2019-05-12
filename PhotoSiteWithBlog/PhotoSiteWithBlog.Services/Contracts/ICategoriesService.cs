using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhotoSiteWithBlog.Data.Models;

namespace PhotoSiteWithBlog.Services.Contracts
{
    public interface ICategoriesService<T>
    {
        int CreateCategory(string name, string description);

        DbSet<Category> ListAll { get; }

        Task<Category> EditCategory(int id, string name, string description);

        Task<Category> DetailCategory(int? id);

        Task<Category> DeleteCategory(int id);
    }
}
