using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Machine> machineModel = _db.Machines.ToList();
      List<Engineer> engineerModel = _db.Engineers.ToList();
      ViewBag.Engineers = engineerModel;
      ViewBag.Machines = machineModel;
      return View();
    }
  }
}