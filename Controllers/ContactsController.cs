using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Contacts.Models;
using System;

namespace Contacts.Controllers
{
    public class ContactsController : Controller
    {

        [Produces("text/html")]
        [Route("/")]
        // [HttpGet("/")]   // change this back?
        public ActionResult Index()
        {
          List<Contact> allContacts = Contact.GetAll();
          return View(allContacts);
        }

        [Route("/Contacts/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/Contacts/create")]
        public ActionResult Create()
        {

          Contact newContact = new Contact (
            Request.Form["first-name"], Request.Form["last-name"],
            Request.Form["company-name"],
            Request.Form["new-address1"], Request.Form["new-address2"],
            Request.Form["new-city"], Request.Form["new-stateOrProvince"],
            Request.Form["new-country"], Request.Form["new-postalcode"],
            Request.Form["first-phone"]
          );
          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
        }

        [HttpGet("/Contacts/{id}")]
        public ActionResult Details(int id)
        {
            Contact chosenContact = Contact.Find(id);
            return View (chosenContact);
        }

        [HttpPost("/Contacts/clear")]
        public ActionResult ClearAll()
        {
            Contact.ClearAll();
            List<Contact> allContacts = Contact.GetAll();
            return View("Index", allContacts);
        }

    }
}
