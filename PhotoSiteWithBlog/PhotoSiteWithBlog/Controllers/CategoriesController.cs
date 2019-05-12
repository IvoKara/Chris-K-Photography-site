using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhotoSiteWithBlog.Services.Contracts;
using PhotoSiteWithBlog.Services;
using Microsoft.EntityFrameworkCore;
using PhotoSiteWithBlog.Data;
using PhotoSiteWithBlog.Data.Models;

namespace PhotoSiteWithBlog.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoriesService<Category> categoriesService;

        public CategoriesController(ICategoriesService<Category> service)
        {
            this.categoriesService = service;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, string description)
        {
            this.categoriesService.CreateCategory(name, description);
            return this.RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Index()
        {
            return View(await categoriesService.ListAll.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await categoriesService.DetailCategory(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await categoriesService.DetailCategory(id);

            if (category == null)
            {
                return NotFound();  
            }

            return View(category);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, string name, string description)
        {
            await this.categoriesService.EditCategory(id, name, description);
            return RedirectToAction(nameof(Details) + $"\\{id}");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await categoriesService.DetailCategory(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await categoriesService.DeleteCategory(id);
            return this.RedirectToAction(nameof(Index));
        }
    }
}
