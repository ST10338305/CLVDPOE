using Microsoft.AspNetCore.Mvc;

namespace CLOUDPOE.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutDisplay()
        {
            return View();
        }
    }
}
