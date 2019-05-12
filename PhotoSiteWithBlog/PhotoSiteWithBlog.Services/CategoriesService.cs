using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhotoSiteWithBlog.Data;
using PhotoSiteWithBlog.Data.Models;
using PhotoSiteWithBlog.Services.Contracts;

namespace PhotoSiteWithBlog.Services
{
    public class CategoriesService : ICategoriesService<Category>
    {
        private PhotoSiteWithBlogDbContext context;

        public CategoriesService(PhotoSiteWithBlogDbContext context)
        {
            this.context = context;
        }

        public DbSet<Category> ListAll { get => context.Categories; }

        public int CreateCategory(string name, string description = "")
        {
            Category categoryNew = new Category() { Name = name, Description = description };
            this.context.Categories.Add(categoryNew);
            this.context.SaveChanges();

            return categoryNew.Id;
        }
        
        public async Task<Category> DetailCategory(int? id)
        {
            return await this.context.Categories
               .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Category> EditCategory(int id, string name, string description)
        {
            var categoryToEdit = await this.DetailCategory(id);
            categoryToEdit.Name = name;
            categoryToEdit.Description = description;
            this.context.Categories.Update(categoryToEdit);
            this.context.SaveChanges();
            return categoryToEdit;
        }

        public async Task<Category> DeleteCategory(int id)
        {
            var categoryToDelete = await context.Categories.FindAsync(id);
            this.context.Categories.Remove(categoryToDelete);
            await this.context.SaveChangesAsync();
            return categoryToDelete;
        }
    }
}
