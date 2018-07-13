using HawkTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HawkTest.Controllers
{
    public class ContactController : Controller
    {

        private ApplicationDbContext _context;
        public ContactController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Contact
        public ActionResult Index()
        {
            var contacts = _context.Contact;
            return View(contacts);
        }

        public ActionResult Update(int id)
        {
            Contact contact = _context.Contact.Find(id);
            return View(contact);
        }

        [HttpPost]
        public ActionResult Update(Contact contact)
        {
            _context.Entry(contact).State = EntityState.Modified;
            _context.SaveChanges();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            _context.Contact.Add(contact);
            _context.SaveChanges();
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {

            Contact contact = _context.Contact.Find(id);
            foreach(ContactDetail number in contact.Detail)
            {
                _context.ContactDetail.Remove(number);
            }
            _context.Contact.Remove(contact);
            _context.SaveChanges();
            return View();
        }


    }
}