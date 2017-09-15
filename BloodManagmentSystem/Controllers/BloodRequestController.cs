using System.Web.Mvc;
using BloodManagmentSystem.Services;

namespace BloodManagmentSystem.Controllers
{
    public class BloodRequestController : Controller
    {
        private readonly IBloodService _service;

        public BloodRequestController(IBloodService service)
        {
            _service = service;
        }

        // GET: BloodRequest
        public ActionResult Create()
        {
            return View(_service.Get());
        }

//        public ActionResult Create()
//        {
//            return View(_service.Get());
//        }
    }
}