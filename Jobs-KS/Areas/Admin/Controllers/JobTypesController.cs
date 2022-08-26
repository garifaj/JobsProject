using Jobs_KS.Data;
using Jobs_KS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs_KS.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class JobTypesController : Controller
    {
        private ApplicationDbContext _context;

        public JobTypesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            //var data = _context.JobTypes.ToList();
            return View(_context.JobTypes.ToList());
        }

        //Create Get action Method
        [Authorize]

        public ActionResult Create()
        {
            return View();
        }

        //Create Post action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobTypes jobTypes)
        {
            if (ModelState.IsValid)
            {
                _context.JobTypes.Add(jobTypes);
                await _context.SaveChangesAsync();
                TempData["save"] = "Job Type has been Saved!";
                return RedirectToAction(actionName: nameof(Index));

            }
            return View(jobTypes);
        }
        //GET Edit Action Method

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobType = _context.JobTypes.Find(id);
            if (jobType == null)
            {
                return NotFound();
            }
            return View(jobType);
        }

        //POST Edit Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(JobTypes jobTypes)
        {
            if (ModelState.IsValid)
            {
                _context.Update(jobTypes);
                await _context.SaveChangesAsync();
                TempData["edit"] = "Job type has been updated";
                return RedirectToAction(nameof(Index));
            }

            return View(jobTypes);
        }

        //GET Details Action Method

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobType = _context.JobTypes.Find(id);
            if (jobType == null)
            {
                return NotFound();
            }
            return View(jobType);
        }

        //POST Details Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(JobTypes jobTypes)
        {
            return RedirectToAction(nameof(Index));

        }
        //GET Delete Action Method

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobType = _context.JobTypes.Find(id);
            if (jobType == null)
            {
                return NotFound();
            }
            return View(jobType);
        }

        //POST Delete Action Method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, JobTypes jobTypes)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (id != jobTypes.Id)
            {
                return NotFound();
            }

            var jobType = _context.JobTypes.Find(id);
            if (jobType == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Remove(jobType);
                await _context.SaveChangesAsync();
                TempData["delete"] = "Job type has been deleted";
                return RedirectToAction(nameof(Index));
            }

            return View(jobTypes);
        }
    }
}
