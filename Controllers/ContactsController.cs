using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Contacts.Models;
using System;

namespace Contacts.Controllers
{
    public class ContactsController : Controller
    {

        // [HttpGet("/items")]
        // public ActionResult Index()
        // {
        //     Item newItem = new Item(Request.Query["new-item"]);
        //     return View(newItem);
        // }
        //
        // [HttpGet("/items/new")]
        // public ActionResult CreateForm()
        // {
        //     return View();
        // }

        // [HttpGet("/items")]
        // public ActionResult Index()
        // {
        //     return View();
        // }
        [Route("/")]
        // [HttpGet("/")]
        public ActionResult Index()
        {
          // Contact myContact = new Contact("Andy", "Grossberg", "5544 SE Hillwood Circle", "", "Portland", "Oregon", "97267", "USA", "(503) 659-5626");
          // Contact anotherContact = new Contact("Bob", "Barr", "5534 SE Hillwood Circle", "", "Portland", "Oregon", "97267", "USA", "(503) 555-1212");

          List<Contact> allContacts = Contact.GetAll(); // This creates the list every time the page is loaded. So I think the list is doubled on refresh!
          return View(allContacts);

          // return View(Contact.GetAll());




        }

        // // [HttpGet("/items")]
        // [HttpGet("/Items")]
        // // [HttpGet("/")]
        //
        // public ActionResult Index()
        // {
        //     List<Item> allItems = Item.GetAll();
        //     return View(allItems);
        // }
        //
        // [HttpGet("/items/new")]
        [Route("/Contacts/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

          //  Console.WriteLine("Got the Post to the right route!");
          // return View();


        //
        [HttpPost("/Contacts/create")]
        public ActionResult Create()
        {

          Contact newContact = new Contact (
            Request.Form["first-name"], Request.Form["last-name"],
            Request.Form["new-address1"], Request.Form["new-address2"],
            Request.Form["new-city"], Request.Form["new-stateOrProvince"],
            Request.Form["new-country"], Request.Form["new-postalcode"],
            Request.Form["first-phone"]
          );

          // newContact.Save();

          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);

          // List<Item> allItems = Item.GetAll();
          // return View("Index", allItems);
          // return View("Items", newItem);
        }
        //
        // // [HttpPost("/items/delete")]
        [HttpPost("/Contacts/clear")]
        public ActionResult ClearAll()
        {
          Console.WriteLine("Got the Post to the right route (/Contacts/clear)!");

            Contact.ClearAll();
            List<Contact> allContacts = Contact.GetAll();
            return View("Index", allContacts);
        }

    }
}
