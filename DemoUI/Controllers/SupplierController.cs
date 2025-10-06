using Microsoft.AspNetCore.Mvc;
using DemoUI.Models;

namespace DemoUI.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Feeds()
        {
            // sample static data — you can later replace with DB data
            var feeds = new List<SupplierFeed>
            {
                new SupplierFeed { Id = 1, Supplier = "Giant", FeedName = "Giant Main Feed", FeedAddress = "Address to API / URL / CSV etc here", ApiKey = "4671265316754", Username = "BoostRetail", Password = "BR1234", Active = true },
                new SupplierFeed { Id = 2, Supplier = "Trek", FeedName = "Trek", FeedAddress = "Address to API / URL / CSV etc here", ApiKey = "4671265316754", Username = "BoostRetail", Password = "BR1234", Active = true },
                new SupplierFeed { Id = 3, Supplier = "Madison", FeedName = "Madison", FeedAddress = "Address to API / URL / CSV etc here", ApiKey = "4671265316754", Username = "BoostRetail", Password = "BR1234", Active = true },
                new SupplierFeed { Id = 4, Supplier = "Zyro Fisher", FeedName = "Zyro Fisher", FeedAddress = "Address to API / URL / CSV etc here", ApiKey = "4671265316754", Username = "BoostRetail", Password = "BR1234", Active = true },
            };
            return View(feeds);
        }
    }
}
