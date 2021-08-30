using CrudEFCoreWithSwagger.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEFCoreWithSwagger.Controllers
{
    public class EMPController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EMPController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: EMPController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EMPController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EMPController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EMPController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EMPController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EMPController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EMPController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
