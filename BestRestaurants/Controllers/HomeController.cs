using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System;
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
        Cuisine[] cuisines = _db.Cuisines.OrderBy(cuisines => cuisines.Type).ToArray();
        Restaurant[] restaurants = _db.Restaurants.OrderBy(restaurants => restaurants.Name).ToArray();
        Tag[] tags = _db.Tags.ToArray();
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        model.Add("cuisines", cuisines);
        model.Add("restaurants", restaurants);
        model.Add("tags", tags);

        return View(model);
      }

    }
}
