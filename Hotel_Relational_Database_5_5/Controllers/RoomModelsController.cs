using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotel_Relational_Database_5_5.Models;

namespace Hotel_Relational_Database_5_5.Controllers
{
    public class RoomModelsController : Controller
    {
        private Hotel_Relational_Database_5_5Context db = new Hotel_Relational_Database_5_5Context();

        // GET: RoomModels
        public ActionResult Index()
        {
            return View(db.RoomModels.ToList());
        }

        // GET: RoomModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomModel roomModel = db.RoomModels.Find(id);
            if (roomModel == null)
            {
                return HttpNotFound();
            }
            return View(roomModel);
        }

        // GET: RoomModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoomID,RoomNumber,RoomPrice,MaxOccupancy")] RoomModel roomModel)
        {
            if (ModelState.IsValid)
            {
                db.RoomModels.Add(roomModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roomModel);
        }

        // GET: RoomModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomModel roomModel = db.RoomModels.Find(id);
            if (roomModel == null)
            {
                return HttpNotFound();
            }
            return View(roomModel);
        }

        // POST: RoomModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RoomID,RoomNumber,RoomPrice,MaxOccupancy")] RoomModel roomModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roomModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roomModel);
        }

        // GET: RoomModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoomModel roomModel = db.RoomModels.Find(id);
            if (roomModel == null)
            {
                return HttpNotFound();
            }
            return View(roomModel);
        }

        // POST: RoomModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RoomModel roomModel = db.RoomModels.Find(id);
            db.RoomModels.Remove(roomModel);
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
