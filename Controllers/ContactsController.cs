using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Contacts.Models;

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
          Contact myContact = new Contact("Andy", "Grossberg", "5544 SE Hillwood Circle", "", "Portland", "Oregon", "USA", "(503) 659-5626");
          return View(myContact);
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
        // // [HttpGet("/items/new")]
        // [HttpGet("/Items/new")]
        // public ActionResult CreateForm()
        // {
        //     return View();
        // }
        //
        // [HttpPost("/Items")]
        // public ActionResult Create()
        // {
        //   Item newItem = new Item (Request.Form["new-item"]);
        //   newItem.Save();
        //   List<Item> allItems = Item.GetAll();
        //   return View("Index", allItems);
        //   // return View("Items", newItem);
        // }
        //
        // // [HttpPost("/items/delete")]
        // [HttpPost("/Items/delete")]
        // public ActionResult DeleteAll()
        // {
        //     Item.ClearAll();
        //     return View();
        // }

    }
}
