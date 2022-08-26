using Microsoft.AspNetCore.Mvc;
using NUnit.Util;
using System.Threading.Tasks;

namespace sefa_basibutun.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cama = new CategoryManager();
        public IActionResult Index()
        {
            var values = cama.GetAll();
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryController c)
        {
            cama.cadd(c);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                cama.cdell(id);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Update(CategoryController c)
        {
            cama.cupdate(c);
            return RedirectToAction("Index");
        }
    }

}
    }
}
