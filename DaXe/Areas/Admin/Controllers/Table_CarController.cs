using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
//using DaXe.Areas.Admin.Models.DaXeDB;

namespace DaXe.Areas.Admin.Controllers
{
    public class Table_CarController : Controller
    {
        //private Entities db = new Entities();

        //// GET: Admin/Table_Car
        //public ActionResult Index()
        //{
        //    return View(db.Table_Car.ToList());
        //}

        //[HttpPost]
        //public ActionResult ChangeStatus(Table_Car car)
        //{
        //    if(car.Status == 0)
        //    {
        //        car.Status = 1;
        //    }
        //    db.Entry(car).State = EntityState.Modified;
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //// GET: Admin/Table_Car/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Table_Car table_Car = db.Table_Car.Find(id);
        //    if (table_Car == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(table_Car);
        //}

        //// GET: Admin/Table_Car/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Admin/Table_Car/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Image,NumberPlates,Name,Category,Old,LevelCar,Service,Routes,Status")] Table_Car table_Car)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Table_Car.Add(table_Car);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(table_Car);
        //}

        //// GET: Admin/Table_Car/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Table_Car table_Car = db.Table_Car.Find(id);
        //    if (table_Car == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(table_Car);
        //}

        //// POST: Admin/Table_Car/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Image,NumberPlates,Name,Category,Old,LevelCar,Service,Routes,Status")] Table_Car table_Car)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(table_Car).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(table_Car);
        //}

        //// GET: Admin/Table_Car/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Table_Car table_Car = db.Table_Car.Find(id);
        //    if (table_Car == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(table_Car);
        //}

        //// POST: Admin/Table_Car/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    Table_Car table_Car = db.Table_Car.Find(id);
        //    db.Table_Car.Remove(table_Car);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
