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
            Image = glove.Image,
            Brand = glove.Brand,
            Title = glove.Title,
            Description = glove.Description,
            //UserTask = glove.UserTasks,
            CreatedUtc = glove.CreatedUtc
        });
        return View(gloves);
    }

    // GET / Create new glove
    public IActionResult Create()
    {
        return View();
    }

    // POST / Create new glove
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(GloveCreate model)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMsg"] = "Model State is Invalid";
            return View(model);
        }
        _context.Gloves.Add(new Glove
        {
            Image = model.Image,
            Title = model.Title,
            Brand = model.Brand,
            Description = model.Description,
            CreatedUtc = DateTimeOffset.Now
        });
        if (_context.SaveChanges() == 1)
        {
            return Redirect("/Glove");
        }
        TempData["ErrorMsg"] = "Unable to save glove to the database. Please try again.";

        return View(model);
    }

    // GET / glove/details/{id}
    public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var glove = _context.Gloves.Find(id);
        if (glove == null)
        {
            return NotFound();
        }
        var model = new GloveDetail
        {
            Image = glove.Image,
            Id = glove.Id,
            Title = glove.Title,
            Brand = glove.Brand,
            Description = glove.Description,
            //UserTask = _context.Tasks.TaskName,
            CreatedUtc = glove.CreatedUtc
        };
        return View(model);
    }

    // GET / Grab a glove's info for edit
    [HttpGet]
    public IActionResult Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var glove = _context.Gloves.Find(id);
        if (glove == null)
        {
            return NotFound();
        }
        var model = new GloveEdit
        {
            Id = glove.Id,
            Image = glove.Image,
            Title = glove.Title,
            Brand = glove.Brand,
            Description = glove.Description,
        };
        return View(model);
    }

    // POST / Edit a glove
    [HttpPost]
    public IActionResult Edit(int id, GloveEdit model)
    {
        var glove = _context.Gloves.Find(id);
        if (glove == null)
        {
            return NotFound();
        }
        glove.Image = model.Image;
        glove.Title = model.Title;
        glove.Brand = model.Brand;
        glove.Description = model.Description;

        if (_context.SaveChanges() == 1)
        {
            return Redirect("/glove");
        }

        ViewData["ErrorMsg"] = "Unable to save glove to the database. Please try again.";

        return View(model);
    }

    // GET / Grab a glove's into for delete
    [HttpGet]
    public IActionResult Delete(int id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var glove = _context.Gloves.Find(id);
        if (glove == null)
        {
            return NotFound();
        }
        var model = new GloveDetail
        {
            Image = glove.Image,
            Id = glove.Id,
            Title = glove.Title,
            Brand = glove.Brand,
            Description = glove.Description,
            //UserTask = _context.Tasks.TaskName,
            CreatedUtc = glove.CreatedUtc
        };
        return View(model);
    }

    // DELETE / Delete a glove
    [HttpPost]
    public IActionResult Delete(int? id, GloveDetail model)
    {
        var glove = _context.Gloves.Find(id);
        if (glove == null)
        {
            return NotFound();
        }
        _context.Gloves.Remove(glove);
        _context.SaveChanges();
        return Redirect("/Glove");
    }
}
