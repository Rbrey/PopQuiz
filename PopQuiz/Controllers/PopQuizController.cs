using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PopQuiz.Controllers
{
    public class PopQuizController : Controller
    {
        // GET: PopQuiz
        public ActionResult Index()
        {
            return View();
        }

        // GET: PopQuiz/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PopQuiz/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PopQuiz/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PopQuiz/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PopQuiz/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PopQuiz/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PopQuiz/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}