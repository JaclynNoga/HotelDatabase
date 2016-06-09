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
    public class GuestModelsController : Controller
    {
        private Hotel_Relational_Database_5_5Context db = new Hotel_Relational_Database_5_5Context();

        // GET: GuestModels
        public ActionResult Index()
        {
            return View(db.ReservationModels.ToList());
        }

        // GET: GuestModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestModel guestModel = db.ReservationModels.Find(id);
            if (guestModel == null)
            {
                return HttpNotFound();
            }
            return View(guestModel);
        }

        // GET: GuestModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GuestModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GuestID,FirstName,LastName,TotalGuests")] GuestModel guestModel)
        {
            if (ModelState.IsValid)
            {
                db.ReservationModels.Add(guestModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guestModel);
        }

        // GET: GuestModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestModel guestModel = db.ReservationModels.Find(id);
            if (guestModel == null)
            {
                return HttpNotFound();
            }
            return View(guestModel);
        }

        // POST: GuestModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GuestID,FirstName,LastName,TotalGuests")] GuestModel guestModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guestModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guestModel);
        }

        // GET: GuestModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestModel guestModel = db.ReservationModels.Find(id);
            if (guestModel == null)
            {
                return HttpNotFound();
            }
            return View(guestModel);
        }

        // POST: GuestModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GuestModel guestModel = db.ReservationModels.Find(id);
            db.ReservationModels.Remove(guestModel);
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
