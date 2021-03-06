using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCModel.Controllers
{
    public class CategoryController : Controller
    {
        private readonly Data.ApplicationDbContext _db;

        public CategoryController(Data.ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Models.Category> objList = _db.Category;
            return View(objList);
        }
    }
}
