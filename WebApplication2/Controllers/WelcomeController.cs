using WebApplication2.DTO;

using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class WelcomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            CustomerDTO customerDTO = new CustomerDTO();
            ViewBag.Message = "Lets Start Again";
            return View(customerDTO);
        }

        [HttpPost]
        public ActionResult Index(CustomerDTO customerDTO)
        {

        }

    }
}