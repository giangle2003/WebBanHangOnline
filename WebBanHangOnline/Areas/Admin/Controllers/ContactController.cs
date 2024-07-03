using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;

namespace WebBanHangOnline.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        // GET: Admin/Contact
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/ContactAdmin
        public ActionResult Index(string Searchtext, int? page)
        {
            ViewBag.Searchtext = Searchtext;

            var contacts = db.Contacts.OrderByDescending(c => c.Id).AsQueryable();

            // Áp dụng tìm kiếm
            if (!string.IsNullOrEmpty(Searchtext))
            {
                contacts = contacts.Where(c => c.Name.Contains(Searchtext));
            }

            // Phân trang
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(contacts.ToPagedList(pageNumber, pageSize));


            //var contacts = db.Contacts.OrderByDescending(c => c.CreatedDate).ToList();
            //return View(contacts);
        }

    }
}