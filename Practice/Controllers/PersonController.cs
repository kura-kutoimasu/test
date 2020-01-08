﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Entities.Data.Models;
using Services.Person.Interfaces;
using AutoMapper;
using Practice.Models;

namespace Practice.Controllers
{
  public class PersonController : Controller
  {
    IPersonService _personService;
    public PersonController(IPersonService personService)
    {
      _personService = personService;
    }
    // GET: Person
    public ActionResult Index()
    {
      return View();
    }

    public JsonResult GetUserList()
    {
      var config = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<Person, PersonViewModel>();
      });
      IMapper mapper = config.CreateMapper();

      var source = _personService.GetAll();
      var dest = mapper.Map<IEnumerable<Person>, IEnumerable<PersonViewModel>>(source);

      return Json(dest);
    }

    // GET: Person/Details/5
    public ActionResult Details(int id)
    {
      return View();
    }

    // GET: Person/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Person/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
      try
      {
        // TODO: Add insert logic here

        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }

    // GET: Person/Edit/5
    public ActionResult Edit(int id)
    {
      return View();
    }

    // POST: Person/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
      try
      {
        // TODO: Add update logic here

        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }

    // GET: Person/Delete/5
    public ActionResult Delete(int id)
    {
      return View();
    }

    // POST: Person/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
      try
      {
        // TODO: Add delete logic here

        return RedirectToAction(nameof(Index));
      }
      catch
      {
        return View();
      }
    }
  }
}