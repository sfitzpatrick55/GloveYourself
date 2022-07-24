using GloveYourself.Data.Models;
using GloveYourself.Models.Glove;
using GloveYourself.WebMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GloveYourself_BlazorWASM.Server.Controllers;

public class GloveController : Controller
{
    // GET: Glove
    public ActionResult Index()
    {
        var model = new GloveListItem[0];
        return View();
    }

    // GET
    public ActionResult Create()
    {
    return View();
    }

    // POST
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(GloveCreate model)
    {
        if (ModelState.IsValid)
        {

        }
        return View(model);
    }

}

