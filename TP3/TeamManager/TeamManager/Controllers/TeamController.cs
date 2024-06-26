﻿using TeamManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using TeamManager.Repositories;

namespace TeamManager.Controllers
{
    public class TeamController : Controller
    {
        // GET: TeamController
        public ActionResult Index()
        {
            var times = TeamsRepository.GetAll();
            return View(times);
        }

        // POST: TeamController
        [HttpPost]
        public ActionResult Index(string searchString)
        {
            var times = TeamsRepository.GetBySearch(searchString);
            return View(times);
        }

        // GET: TeamController/Details/5
        public ActionResult Details(Guid id)
        {
            var times = TeamsRepository.GetById(id);
            return View(times);
        }

        // GET: TeamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TeamViewModel time)
        {
            try
            {
                TeamsRepository.Create(time);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var time = TeamsRepository.GetById(id);
            return View(time);
        }

        // POST: TeamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, TeamViewModel time)
        {
            try
            {
                TeamsRepository.Update(time);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TeamController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var time = TeamsRepository.GetById(id);
            return View(time);
        }

        // POST: TeamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            try
            {
                TeamsRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
