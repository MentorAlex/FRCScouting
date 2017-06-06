using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Scouting.DAL;
using Scouting.Models;

namespace Scouting.Controllers
{
    public class MatchController : Controller
    {
        private ScoutingContext db = new ScoutingContext();

        // GET: Match
        public ActionResult Index()
        {
            var matches = db.Matches.Include(m => m.Stats).Include(m => m.Team);
            return View(matches.ToList());
        }

        // GET: Match/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Match match = db.Matches.Find(id);
            if (match == null)
            {
                return HttpNotFound();
            }
            return View(match);
        }

        // GET: Match/Create
        public ActionResult Create()
        {
         //   ViewBag.StatsID = new SelectList(db.Stats, "StatsID", "StatsID");
            ViewBag.TeamID = new SelectList(db.Teams, "TeamID", "TeamID");
            return View();
        }

        // POST: Match/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MatchID,TeamID,Score,Result,Shooter")] Match match)
        {
            if (ModelState.IsValid)
            {
                db.Matches.Add(match);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

        //    ViewBag.StatsID = new SelectList(db.Stats, "StatsID", "StatsID", match.StatsID);
            ViewBag.TeamID = new SelectList(db.Teams, "TeamID", "Name", match.TeamID);
            return View(match);
        }

        // GET: Match/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Match match = db.Matches.Find(id);
            if (match == null)
            {
                return HttpNotFound();
            }
       //     ViewBag.StatsID = new SelectList(db.Stats, "StatsID", "StatsID", match.StatsID);
            ViewBag.TeamID = new SelectList(db.Teams, "TeamID", "Name", match.TeamID);
            return View(match);
        }

        // POST: Match/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MatchID,TeamID,StatsID,Score,Result")] Match match)
        {
            if (ModelState.IsValid)
            {
                db.Entry(match).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
         //   ViewBag.StatsID = new SelectList(db.Stats, "StatsID", "StatsID", match.StatsID);
            ViewBag.TeamID = new SelectList(db.Teams, "TeamID", "Name", match.TeamID);
            return View(match);
        }

        // GET: Match/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Match match = db.Matches.Find(id);
            if (match == null)
            {
                return HttpNotFound();
            }
            return View(match);
        }

        // POST: Match/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Match match = db.Matches.Find(id);
            db.Matches.Remove(match);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
