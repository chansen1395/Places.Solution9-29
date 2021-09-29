using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class LocationsController : Controller
  {

    [HttpGet("/locations")]
    public ActionResult Index()
    {
      List<Location> allLocations = Location.GetAll();
      return View(allLocations);
    }

  [HttpGet("/locations/new")]
  public ActionResult New()
  {
    return View();
  }

    [HttpPost("/locations")]
    public ActionResult Create(string cityname, int days, string travelWith)
    {
      Location myLocation = new Location(cityname, days, travelWith);
      return RedirectToAction("Index");
    }

    [HttpPost("/locations/delete")]
    public ActionResult DeleteAll()
    {
      Location.ClearAll();
      return View();
    }

    [HttpGet("/locations/{id}")]
    public ActionResult Show(int id)
    {
      Location foundLocation = Location.Find(id);
      return View(foundLocation);
    }
  }
}