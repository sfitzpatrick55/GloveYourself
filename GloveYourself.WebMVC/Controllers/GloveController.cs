using GloveYourself.Data.Models;
using GloveYourself.Models.Glove;
using GloveYourself.Services.Glove;
using GloveYourself.Data.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GloveYourself_BlazorWASM.Server.Controllers;

public class GloveController : Controller
{
    private readonly ApplicationDbContext _context;

    public GloveController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET all gloves
    public IActionResult Index()
    {
        var gloves = _context.Gloves.Select(glove => new GloveIndex
        {
            Id = glove.Id,
            Brand = glove.Brand,
            Title = glove.Title,
            Description = glove.Description,
            UserTask = glove.TaskId,
            CreatedUtc = glove.CreatedUtc
        });
        return View(gloves);

    }
    // GET all gloves
    //public ActionResult IndexAllGloves()
    //{
    //    var model = new GloveListItem[0];
    //    return View(model);
    //}

    // GET / Display all gloves for the current user
    //public ActionResult Index()
    //{
    //    var userId = Guid.Parse(User.Identity.GetUserId());
    //    var service = new GloveService(userId);
    //    var model = service.GetGloves();

    //    return View(model);
    //}

    // GET
    //public ActionResult Create()
    //{
    //    return View();
    //}

    //// POST / Create new glove
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Create(GloveCreate model)
    //{
    //    if (ModelState.IsValid)
    //    {

    //    }
    //    return View(model);
    //}

    //// POST / Create new glove by userId
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult CreateById(GloveCreate model)
    //{
    //    if (!ModelState.IsValid)
    //    {
    //        return View(model);
    //    }

    //    var userId = Guid.Parse(User.Identity.GetUserId());
    //    var service = new GloveService(userId);

    //    service.CreateGlove(model);

    //    return RedirectToAction("Index");
    //}

}

