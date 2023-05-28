using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CvStorage.Data;
using CvStorage.Models;
using CvStorage.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CvStorage.Controllers
{
    public class CvController : Controller
    {

        private readonly CvContext context;
        private readonly ICvRepository repository;

        public CvController(CvContext _context, ICvRepository _repository)
        {
            context = _context;
            repository = _repository;
        }


        public IActionResult Index()
        {
            IEnumerable<Cv> objList = context.Cvs;
            return View(objList);
        }

        //GET - EDIT
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = context.Cvs.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }




        public ViewResult AddCv(Cv cv)
        {
            int id = 0;
            if (ModelState.IsValid)
            {
                id = repository.AddCv(cv);
                ViewBag.isSuccess = true;
                return View("Success");
            }

            ViewBag.Id = id;
            return View();

        }
    }
}
