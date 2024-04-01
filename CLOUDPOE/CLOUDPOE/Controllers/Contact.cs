using Microsoft.AspNetCore.Mvc;

namespace CLOUDPOE.Controllers
{
    public class Contact : Controller
    {
        public IActionResult ContactDisplay()
        {
            return View();
        }
    }
}
