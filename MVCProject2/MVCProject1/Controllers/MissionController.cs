using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCProject1.DAL;
using MVCProject1.Models;

namespace MVCProject1.Controllers
{
    public class MissionController : Controller
    {
        private MissionControlContext db = new MissionControlContext();

        // GET: Mission
        public ActionResult Index()
        {
            return View(db.Mission.ToList());
        }

        // GET: Mission/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionModel missionModel = db.Mission.Find(id);
            if (missionModel == null)
            {
                return HttpNotFound();
            }
            return View(missionModel);
        }

        // GET: Mission/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mission/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "missionID,missionName,missionPresidentName,missionLanguage,missionClimate,missionDomReligion,missionPresidentPicLink,missionFlagLink,missionAddress,missionCity,missionState,missionCountry,missionZip")] MissionModel missionModel)
        {
            if (ModelState.IsValid)
            {
                db.Mission.Add(missionModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(missionModel);
        }

        // GET: Mission/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionModel missionModel = db.Mission.Find(id);
            if (missionModel == null)
            {
                return HttpNotFound();
            }
            return View(missionModel);
        }

        // POST: Mission/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "missionID,missionName,missionPresidentName,missionLanguage,missionClimate,missionDomReligion,missionPresidentPicLink,missionFlagLink,missionAddress,missionCity,missionState,missionCountry,missionZip")] MissionModel missionModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(missionModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(missionModel);
        }

        // GET: Mission/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MissionModel missionModel = db.Mission.Find(id);
            if (missionModel == null)
            {
                return HttpNotFound();
            }
            return View(missionModel);
        }

        // POST: Mission/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MissionModel missionModel = db.Mission.Find(id);
            db.Mission.Remove(missionModel);
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
