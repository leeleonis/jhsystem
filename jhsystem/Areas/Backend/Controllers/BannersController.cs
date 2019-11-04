using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using jhsystem.Models;

namespace jhsystem.Areas.Backend.Controllers
{
    public class BannersController : Controller
    {
        private Entities db = new Entities();

        // GET: Backend/Banners
        public ActionResult Index()
        {
            return View(db.Banner.ToList());
        }

        // GET: Backend/Banners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banner banner = db.Banner.Find(id);
            if (banner == null)
            {
                return HttpNotFound();
            }
            return View(banner);
        }

        // GET: Backend/Banners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Backend/Banners/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IsEnable,ID,Title,Body,SEO,Sort,PageKey,ShowTime,Url,CreateBy,CreateAt,UpdateBy,UpdateAt,Memo")] Banner banner)
        {
            if (ModelState.IsValid)
            {
                db.Banner.Add(banner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(banner);
        }

        // GET: Backend/Banners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banner banner = db.Banner.Find(id);
            if (banner == null)
            {
                return HttpNotFound();
            }
            return View(banner);
        }

        // POST: Backend/Banners/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IsEnable,ID,Title,Body,SEO,Sort,PageKey,ShowTime,Url,CreateBy,CreateAt,UpdateBy,UpdateAt,Memo")] Banner banner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(banner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(banner);
        }

        // GET: Backend/Banners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Banner banner = db.Banner.Find(id);
            if (banner == null)
            {
                return HttpNotFound();
            }
            return View(banner);
        }

        // POST: Backend/Banners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Banner banner = db.Banner.Find(id);
            db.Banner.Remove(banner);
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
