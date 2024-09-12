using Microsoft.AspNetCore.Mvc;
using VigilanceFire.Models;
using VigilanceFire.Repository;

namespace VigilanceFire.Controllers
{
    public class Evacuation_InstructionsController : Controller
    {
        IEvacuation_InstructionsRepository instructionsRepo;

        public Evacuation_InstructionsController(IEvacuation_InstructionsRepository _instructionRepo)
        {
            instructionsRepo = _instructionRepo ;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Evacuation_Instructions instructions)
        {
            if (ModelState.IsValid)
            {
                instructionsRepo.AddInstruction(instructions);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Details(int id)
        {

            return View();
        }

        public IActionResult Delete(int id)
        {

            return View();
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            return RedirectToAction("Index");
        }

        public IActionResult Update(int? Id)
        {

            return View();
        }

        [HttpPost]
        public IActionResult Update(Evacuation_Instructions instructions)
        {

            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
