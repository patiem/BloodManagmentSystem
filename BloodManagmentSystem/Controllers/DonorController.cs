using System.Data;
using System.Web.Mvc;
using BloodManagmentSystem.Models;
using BloodManagmentSystem.Services;

namespace BloodManagmentSystem.Controllers
{
    public class DonorController : Controller
    {
        private readonly IDonorService _service;

        public DonorController(IDonorService service)
        {
            _service = service;
        }
        
        // GET: Donor
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, Email, BloodType, City")]Donor donor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _service.Add(donor);
                    _service.Save();
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View();
        }
    }
}