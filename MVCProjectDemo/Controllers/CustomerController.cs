using Microsoft.AspNetCore.Mvc;
using MVCProjectDemo.Models;
using System.Linq;

namespace MVCProjectDemo.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Customer s)
        {
            var data=dbContext.customers.Where(Model=>Model.Username==s.Username && Model.Password==s.Password).SingleOrDefault();
            if(data==null)
            {
                ViewBag.Error = "invalid user";
                return View();

            }
            {
                return RedirectToAction("Index","Product");
            }
            
        }
        public IActionResult Registration()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult Registration(Customer cus)
        {
            dbContext.customers.Add(cus);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
           
        }
    }
}
