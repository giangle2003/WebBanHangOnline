using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;

namespace WebBanHangOnline.Controllers
{
    public class ContactController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Contact contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    contact.CreatedDate = DateTime.Now;
                    contact.ModifiedDate = DateTime.Now;
                    contact.IsRead = false;

                    db.Contacts.Add(contact);
                    db.SaveChanges();

                    TempData["SuccessMessage"] = "Cảm ơn bạn đã liên hệ! Chúng tôi sẽ sớm phản hồi.";
                  
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error saving contact message: " + ex.Message);

                }
                
            }

            return View(contact);
        }

    }
}
