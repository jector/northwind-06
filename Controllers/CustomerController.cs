using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;


    public class CustomerController(DataContext db) : Controller
    {
        private readonly DataContext _dataContext = db;

        public ActionResult Index() => View(_dataContext.Customer.OrderByDescending(c => c.CustomerId));
        public ActionResult Register() => View(new Customer());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Customer model)
        {

            if (ModelState.IsValid)
            {

                if (_dataContext.Customer.Any(c => c.CompanyName == model.CompanyName))
                {
                    ModelState.AddModelError("", "Name must be unique");
                }
                else
                {
                    _dataContext.AddCustomer(model);
                    return RedirectToAction("Index");
                }

            }
            return View();
        }
    }
