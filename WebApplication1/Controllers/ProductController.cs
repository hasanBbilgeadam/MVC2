using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {

        public static List<Product> list = new();

       

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Product product)
        {
            list.Add(product);

            return RedirectToAction("List");
        }

        public IActionResult delete(int id)
        {
            var data= list.Where(x => x.Id == id).FirstOrDefault();
            list.Remove(data);
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            return View(list);
        }
    }
}
