using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonelController : Controller
    {


        List<Personel> list = new List<Personel>()
        {

            new(1,"hasan","ankara","beni işe al 1",Gender.erkek),
            new(2,"serger","adana","beni işe al 2 ",Gender.erkek),
            new(3,"burcu","ankara","beni işe al 3 " ,Gender.kadın),
            new(4,"ozan","ısparta","beni işe al 4",Gender.erkek),
            new(5,"mehmet","ankara","beni işe al 5",Gender.erkek),
            new(6,"x","ankara","beni işe al 5",Gender.none),


        };
        public IActionResult Index()
        {
            return View();
        }

        //   personel/list
        public IActionResult List()
        {

            return View(list);
        }

        public IActionResult Profile(int id)
        {
            var data = list.Where(x => x.Id == id).FirstOrDefault();


            return View(data);
        }
    }
}
