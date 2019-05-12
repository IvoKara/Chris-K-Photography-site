using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoSiteWithBlog.Data.Models;
using PhotoSiteWithBlog.Services.Contracts;
using PhotoSiteWithBlog.Services;

namespace PhotoSiteWithBlog.Controllers
{
    public class PostsController : Controller
    {
        private IPostsService<Post> postsService;

        public PostsController(IPostsService<Post> service)
        {
            this.postsService = service;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string category, 
            string shortDescription, string content)
        {
            this.postsService.CreatePost(title, category, shortDescription, content);
            return this.RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Index()
        {
            return View(await postsService.ListAll.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Post = await postsService.DetailPost(id);

            if (Post == null)
            {
                return NotFound();
            }

            return View(Post);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Post = await postsService.DetailPost(id);

            if (Post == null)
            {
                return NotFound();
            }

            return View(Post);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, string title,
            string category, string shortDescription, string content)
        {
            await this.postsService.EditPost(id, title, category, content,
                shortDescription);
            return RedirectToAction(nameof(Details) + $"\\{id}");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Post = await postsService.DetailPost(id);
            if (Post == null)
            {
                return NotFound();
            }

            return View(Post);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await postsService.DeletePost(id);
            return this.RedirectToAction(nameof(Index));
        }
    }
}
