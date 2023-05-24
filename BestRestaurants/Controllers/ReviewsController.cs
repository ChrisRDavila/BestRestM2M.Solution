using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BestRestaurants.Controllers
{
  public class ReviewsController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public ReviewsController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Reviews.ToList());
    }

    public ActionResult Details(int id)
    {
      Review thisReview = _db.Reviews
          .Include(review => review.JoinEntities)
          .ThenInclude(join => join.Restaurant)
          .FirstOrDefault(review => review.ReviewId == id);
      return View(thisReview);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}    