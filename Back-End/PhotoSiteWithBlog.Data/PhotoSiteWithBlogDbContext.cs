using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using PhotoSiteWithBlog.Data.Models;

namespace PhotoSiteWithBlog.Data
{
    public class PhotoSiteWithBlogDbContext : DbContext
    {
        public PhotoSiteWithBlogDbContext(DbContextOptions<PhotoSiteWithBlogDbContext> options) : 
            base(options) { }


        public DbSet<Post> Posts { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationData.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>().HasKey(t => new { t.PostId, t.TagId });
        }
    }
}
