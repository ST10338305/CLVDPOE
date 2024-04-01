using Microsoft.AspNetCore.Mvc;
using CLOUDPOE.Models;
namespace CLOUDPOE.Controllers
{

    public class MyWorkController : Controller
    {
    public ActionResult Display()
    {
        // Static craftwork information
        var craftWorks = new List <CraftWorkModel>
            {
            new CraftWorkModel { Name = "Handmade Wooden Jewelry Box", Description = "Beautifully crafted jewelry box made from high-quality wood.", Price = 45.00m, ImageUrl = "/Images/Jewelry box.jpg" },
    new CraftWorkModel { Name = "Handwoven Basket", Description = "Sturdy and stylish basket handwoven with natural fibers.", Price = 30.00m, ImageUrl = "/Images/HandWoven basket resize.jpg" },
    new CraftWorkModel { Name = "Handmade Ceramic Mug", Description = "Unique ceramic mug with a hand-painted design.", Price = 20.00m, ImageUrl = "/Images/Ceramic Mug.jpg" },
    new CraftWorkModel { Name = "Handcrafted Leather Wallet", Description = "Elegant leather wallet with multiple compartments.", Price = 50.00m, ImageUrl = "/Images/CrazyLeather.jpg" },
    new CraftWorkModel { Name = "Handmade Dreamcatcher", Description = "Intricately designed dreamcatcher with feathers and beads.", Price = 35.00m, ImageUrl = "/Images/dream catcher.jpg" },
    new CraftWorkModel { Name = "Hand-painted Silk Scarf", Description = "Luxurious silk scarf hand-painted with vibrant colors.", Price = 60.00m, ImageUrl = "/Images/Spanish Scarf.jpg" },
    new CraftWorkModel { Name = "Hand-carved Wooden Bowl", Description = "Exquisite wooden bowl carved from a single piece of wood.", Price = 40.00m, ImageUrl = "/Images/Wooden Bowls.jpg" },
    new CraftWorkModel { Name = "Handmade Beaded Necklace", Description = "Statement necklace featuring intricate beadwork.", Price = 25.00m, ImageUrl = "/Images/Long Wood Necklace.jpg" },
    new CraftWorkModel { Name = "Handcrafted Soap Gift Set", Description = "Artisanal soap set with a variety of scents and shapes.", Price = 35.00m, ImageUrl = "/Images/Alkanet soap.jpg" },
    
            };

        return View(craftWorks);
    }
}
}
