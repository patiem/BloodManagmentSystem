using System.Web.Mvc;

namespace BloodManagmentSystem.Controllers
{
    public class DonorController : Controller
    {
        // GET: Donor
        public ActionResult Create()
        {
            return View();
        }
    }
}