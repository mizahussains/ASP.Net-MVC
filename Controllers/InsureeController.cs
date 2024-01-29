using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class InsureeController : Controller
    {
        private readonly YourDbContext _dbContext;

        public InsureeController(YourDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Other controller actions...

        [HttpPost]
        public ActionResult CalculateQuote(InsureeViewModel model)
        {
            decimal quote = CalculateInsuranceQuote(model); // Implement the quote calculation logic

            var insuree = new Insuree
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Quote = quote
            };

            _dbContext.Insurees.Add(insuree);
            _dbContext.SaveChanges();

            return RedirectToAction("Index"); // Redirect to the appropriate view
        }

        // Other controller actions...

        private decimal CalculateInsuranceQuote(InsureeViewModel model)
        {
            // Implement the quote calculation logic (as in the previous examples)
            // ...

            return calculatedQuote;
        }
    }

}
