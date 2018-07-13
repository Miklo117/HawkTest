using HawkTest.Models;
using System;
using System.Collections.Generic;
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
            var details = _context.ContactDetail;
            return View(details);
        }
    }
}