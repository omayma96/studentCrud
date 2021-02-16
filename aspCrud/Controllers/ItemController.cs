using aspCrud.Data;
using aspCrud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspCrud.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDBContext _db;
        public ItemController(ApplicationDBContext db)
        {
            _db = db;
        }
   

        public IActionResult Index()
        {
            var viewdt = _db.Items.ToList();
            return View(viewdt);
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public async Task<ActionResult> Create(Item st)
        {
            if (ModelState.IsValid)
            {
                _db.Add(st);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(st);
        }
        public async Task<ActionResult> Update(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var stdDetails = await _db.Items.FindAsync(id);
            return View(stdDetails);
        }

        [HttpPost]

        public async Task<ActionResult> Update(Item stu)
        {
            if (ModelState.IsValid)
            {
                _db.Update(stu);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(stu);
        }

        public async Task<ActionResult> Read(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var stdDetails = await _db.Items.FindAsync(id);
            return View(stdDetails);
        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var stdDetails = await _db.Items.FindAsync(id);
            return View(stdDetails);
        }

        [HttpPost]

        public async Task<ActionResult> Delete(int id)
        {

            var stdDetails = await _db.Items.FindAsync(id);
            _db.Items.Remove(stdDetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");



        }
    }
}
