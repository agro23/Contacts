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
        // [HttpGet("/")]   // change this back?
        public ActionResult Index()
        {
          // Contact myContact = new Contact("Andy", "Grossberg", "5544 SE Hillwood Circle", "", "Portland", "Oregon", "97267", "USA", "(503) 659-5626");
          // Contact anotherContact = new Contact("Bob", "Barr", "5534 SE Hillwood Circle", "", "Portland", "Oregon", "97267", "USA", "(503) 555-1212");

// This creates the list every time the page is loaded. So I think the list is doubled on refresh!
// This issue should vanish when I produce the list of links to details pages.

          List<Contact> allContacts = Contact.GetAll();
          return View(allContacts);
          // return View(Contact.GetAll());
        }



// NEED THE DETAILS PAGE:
        [HttpGet("/Contacts/{id}")]
        public ActionResult Details(int id)
        {
            // Dictionary<string, object> model = new Dictionary<string, object>(); // don't need a dictionary, just a list
            Contact chosenContact = Contact.Find(id);
            // Console.WriteLine("Got the chosen Contact at least!");
            // Console.WriteLine("And it is in the city: " + chosenContact.GetCity());

            // string showingContact += chosenContact.GetFirstName();
            // List<Contact>  = selectedCategory.GetItems();
            // model.Add("category", selectedCategory);
            // model.Add("items", categoryItems);

            // BUILD THE STRING FROM THE OBJECT
            // model is that string below
            // return View(chosenContact); // pass the object to the details page and list it since it's just HTML
            return View (chosenContact);
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
