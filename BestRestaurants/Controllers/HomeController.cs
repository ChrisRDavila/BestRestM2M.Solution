using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
    public class HomeController : Controller
    {
      private readonly BestRestaurantsContext _db;

      public HomeController(BestRestaurantsContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        Cuisine[] cuisines = _db.Cuisines.ToArray();
        Restaurant[] restaurants = _db.Restaurants.ToArray();
        Review[] reviews = _db.Reviews.ToArray();
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        model.Add("cuisines", cuisines);
        model.Add("restaurants", restaurants);
        model.Add("reviews", reviews);

        return View(model);
      }

    }
}

// using list and viewbag to pass categories and items into view
// [HttpGet("/")]
//       public ActionResult Index()
//       {
//         List<Category> cats = _db.Categories.ToList();
//         List<Item> items = _db.Items.ToList();
//         ViewBag.categories = cats;
//         ViewBag.items = items;
//         return View();
//       }