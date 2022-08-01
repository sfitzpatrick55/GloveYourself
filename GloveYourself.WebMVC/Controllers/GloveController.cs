using GloveYourself.Data.Models;
using GloveYourself.Models.Glove;
using GloveYourself.Services.Glove;
using GloveYourself.Data.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace GloveYourself_BlazorWASM.Server.Controllers;

[Authorize]
public class GloveController : Controller
{
    //IGloveService constructor

    private readonly IGloveService _gloveService;

    public GloveController(IGloveService gloveService)
    {
        _gloveService = gloveService;
    }

    // GET all gloves

    public IActionResult Index()
    {
        return View(_gloveService.GetGloves());
    }

    //
    // GET: / glove/create

    public IActionResult Create()
    {
        // ViewBag dropdown here
        return View();
    }

    //
    // POST: / glove/create

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(GloveCreate model)
    {
        if (!_gloveService.CreateGlove(model))
        {
            // ViewBag dropdown here
            return View();

        }
        return RedirectToAction("Index");
    }

    //
    // GET: / glove/details/{id}
    public IActionResult Details(int? id)
    {
        return View(/*GloveDetail*/);
    }

    //
    // GET: / glove/edit/{id}
    [HttpGet]
    public IActionResult Edit(int id)
    {
        return View(/*GloveEdit*/);
    }

    //
    // POST: / glove/edit/{id}
    [HttpPost]
    public IActionResult Edit(int id, GloveEdit model)
    {
        if (!_gloveService.EditGlove(model))
            return View();
        return RedirectToAction("Index");
    }

    //
    // GET: / glove/delete/{id}
    [HttpGet]
    public IActionResult Delete(int id)
    {
        return View(/*GloveDetail*/);
    }

    //
    // POST: / glove/delete/{id}
    [HttpPost]
    public IActionResult Delete(int id)
    {
        return RedirectToAction("Index");
    }
}
