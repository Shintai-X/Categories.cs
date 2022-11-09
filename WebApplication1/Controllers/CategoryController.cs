using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDBcontext _db;
        public CategoryController(ApplicationDBcontext db)
        {
            _db = db;
        }
        

        public IActionResult Index()
        {
            IEnumerable<Categorie> objCategoryList = _db.categories;
            return View(objCategoryList);
        }

        public IActionResult Formulaire()
        {
     
            return View();
        }
    }
}
