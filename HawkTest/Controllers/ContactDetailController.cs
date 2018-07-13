using HawkTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HawkTest.Controllers
{
    public class ContactDetailController : Controller
    {
        private ApplicationDbContext _context;

        public ContactDetailController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: ContactDetail
        public ActionResult Index()
        {
            var numbers = _context.ContactDetail;
            return View(numbers);
        }

        public ActionResult Update(int id)
        {
            ContactDetail number = _context.ContactDetail.Find(id);
            return View(number);
        }

        [HttpPost]
        public ActionResult Update(ContactDetail number)
        {
            _context.Entry(number).State = EntityState.Modified;
            _context.SaveChanges();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ContactDetail number)
        {
            _context.ContactDetail.Add(number);
            _context.SaveChanges();
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {

            ContactDetail number = _context.ContactDetail.Find(id);
            
            _context.ContactDetail.Remove(number);
            _context.SaveChanges();
            return View();
        }
    }
}