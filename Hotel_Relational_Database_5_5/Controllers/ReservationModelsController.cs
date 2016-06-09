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
    public class ReservationModelsController : Controller
    {
        private Hotel_Relational_Database_5_5Context db = new Hotel_Relational_Database_5_5Context();

        // GET: ReservationModels
        public ActionResult Index()
        {
            var reservationModels1 = db.ReservationModels1.Include(r => r.Guest).Include(r => r.Room);
            return View(reservationModels1.ToList());
        }

        // GET: ReservationModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReservationModel reservationModel = db.ReservationModels1.Find(id);
            if (reservationModel == null)
            {
                return HttpNotFound();
            }
            return View(reservationModel);
        }

        // GET: ReservationModels/Create
        public ActionResult Create()
        {
            ViewBag.GuestID = new SelectList(db.ReservationModels, "GuestID", "FirstName");
            ViewBag.RoomID = new SelectList(db.RoomModels, "RoomID", "RoomID");
            return View();
        }

        // POST: ReservationModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReservationID,GuestID,RoomID")] ReservationModel reservationModel)
        {
            if (ModelState.IsValid)
            {
                db.ReservationModels1.Add(reservationModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GuestID = new SelectList(db.ReservationModels, "GuestID", "FirstName", reservationModel.GuestID);
            ViewBag.RoomID = new SelectList(db.RoomModels, "RoomID", "RoomID", reservationModel.RoomID);
            return View(reservationModel);
        }

        // GET: ReservationModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReservationModel reservationModel = db.ReservationModels1.Find(id);
            if (reservationModel == null)
            {
                return HttpNotFound();
            }
            ViewBag.GuestID = new SelectList(db.ReservationModels, "GuestID", "FirstName", reservationModel.GuestID);
            ViewBag.RoomID = new SelectList(db.RoomModels, "RoomID", "RoomID", reservationModel.RoomID);
            return View(reservationModel);
        }

        // POST: ReservationModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReservationID,GuestID,RoomID")] ReservationModel reservationModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reservationModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GuestID = new SelectList(db.ReservationModels, "GuestID", "FirstName", reservationModel.GuestID);
            ViewBag.RoomID = new SelectList(db.RoomModels, "RoomID", "RoomID", reservationModel.RoomID);
            return View(reservationModel);
        }

        // GET: ReservationModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReservationModel reservationModel = db.ReservationModels1.Find(id);
            if (reservationModel == null)
            {
                return HttpNotFound();
            }
            return View(reservationModel);
        }

        // POST: ReservationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReservationModel reservationModel = db.ReservationModels1.Find(id);
            db.ReservationModels1.Remove(reservationModel);
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
