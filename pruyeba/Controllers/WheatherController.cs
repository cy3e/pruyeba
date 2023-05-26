using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pruyeba.Controllers
{
    public class WheatherController : Controller
    {
        // GET: WheatherController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WheatherController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WheatherController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WheatherController/Create
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

        // GET: WheatherController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WheatherController/Edit/5
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

        // GET: WheatherController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WheatherController/Delete/5
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
