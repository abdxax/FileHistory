using FileHistory.Data;
using FileHistory.Dots;
using FileHistory.Repstory;
using FileHistory.Service;
using Microsoft.AspNetCore.Mvc;

namespace FileHistory.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDepartmentRepstory _depa;
        public HomeController(FileDBContext db)
        {
            _depa=new DepartmentService(db);
        }
        public IActionResult Index()
        {
            //var x = new DepartmentDots();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Depart depart)
        {
            _depa.addDepartment(depart);
            //var x = new DepartmentDots();
            return View();
        }
    }
}
