using Jobs_KS.Data;
using Jobs_KS.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs_KS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobsController : Controller
    {
        private ApplicationDbContext _context;
        private IWebHostEnvironment _he;

        public JobsController(ApplicationDbContext context, IWebHostEnvironment he)
        {
            _context = context;
            _he = he;
        }
        public IActionResult Index()
        {
            return View(_context.Jobs.Include(c => c.JobTypes).ToList());
        }


        //Get Create method
        public IActionResult Create()
        {
            ViewData["jobTypeId"] = new SelectList(_context.JobTypes.ToList(), "Id", "JobType");
            return View();
        }


        //Post Create method
        [HttpPost]
        public async Task<IActionResult> Create(Job job, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                var searchJob = _context.Jobs.FirstOrDefault(c => c.Description == job.Description);
                if (searchJob != null)
                {
                    ViewBag.message = "This job is already exist";
                    ViewData["jobTypeId"] = new SelectList(_context.JobTypes.ToList(), "Id", "JobType");
                    return View(job);
                }

                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    job.Image = "Images/" + image.FileName;
                }

                if (image == null)
                {
                    job.Image = "Images/NoImageFound.png";
                }
                _context.Jobs.Add(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(job);
        }
        //GET Edit Action Method

        public ActionResult Edit(int? id)
        {
            ViewData["jobTypeId"] = new SelectList(_context.JobTypes.ToList(), "Id", "JobType");
            if (id == null)
            {
                return NotFound();
            }

            var job = _context.Jobs.Include(c => c.JobTypes)
                .FirstOrDefault(c => c.ID == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }

        //POST Edit Action Method
        [HttpPost]
        public async Task<IActionResult> Edit(Job job, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    job.Image = "Images/" + image.FileName;
                }

                if (image == null)
                {
                    job.Image = "Images/NoImageFound.png";
                }
                _context.Jobs.Update(job);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(job);
        }


        //GET Details Action Method
        public ActionResult Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var job = _context.Jobs.Include(c => c.JobTypes)
                .FirstOrDefault(c => c.ID == id);
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }
        //GET Delete Action Method

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = _context.Jobs.Include(c => c.JobTypes).Where(c => c.ID == id).FirstOrDefault();
            if (job == null)
            {
                return NotFound();
            }
            return View(job);
        }

        //POST Delete Action Method

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var job = _context.Jobs.FirstOrDefault(c => c.ID == id);
            if (job == null)
            {
                return NotFound();
            }

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
