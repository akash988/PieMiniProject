using Microsoft.AspNetCore.Mvc;
using PieMiniProject.DataAccess.Repository.IRepository;
using PieMiniProject.ModelAccess.Models;

namespace PieMiniProject.Controllers
{
    public class PieController : Controller
    {
        public readonly IUnitOfWork _unitOfWork;

        public PieController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            var allPie = _unitOfWork.Product.GetAll();
            return View(allPie);
        }
        public IActionResult Details(int? id)
        {
            var pieObj = _unitOfWork.Product.GetFirstOrDefault(c => c.Id == id);
            return View(pieObj);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        // Create Post Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pie catobj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Product.Add(catobj);
                _unitOfWork.Save();
                TempData["Success"] = "Sucessfully Inserted the data";
                return RedirectToAction("Index");// runtime errors

            }
            return View(catobj);
        }

    }
}
