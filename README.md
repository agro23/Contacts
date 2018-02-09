# ADDRESS BOOK

#### _Contacts, 02/09/18_

#### _**Andy Grossberg**_

## Description

_The Friday Independent Code Review for Week One of C# at Epicodus:_
_This is a simple Address Book._

## Location

**_You can find this file at:_**
* https://github.com/agro23/Contacts.git

## Rules for the Contact List assignment

_Using MVC, make an address book where you can store contact information for people you know. Use Razor to display information on each page.

Create a Contact class. This class should include properties for the person's name, phone number and address.
The homepage of the app at the root path (localhost:5000) should list all Contacts.
The homepage should also contain a link to a page presenting the user with a form they can fill out to create a new Contact. After the form is submitted, the new Contact object should be saved into a static List and the user should be routed back to the homepage.
The homepage should also contain a form with only a clear button at the bottom of the list of all contacts. When this is pressed, all Contacts should be deleted, and the user should be routed back to the homepage._

## Methodology

_I followed the same approach as we took with the To-do List project from our work during the week. I simply made a similar Model, View, and Controller but suited to my needs. The Contact object contains the Contact Name (First and Last separated), two Address lines, a City, a State/Province, a Postal Code, a Country, and a Phone Number. All of these fields are of type String (including the Phone Number because of modifying characters such as '+', '(', ')', '.' and '-')._

_The Contact Object contains encapsulated private data and a constructor as well as Getter and Setter methods. I have also included a Find() method to search the Contact List, a GetAll() to retrieve the entire List, a GetID() to use for retrieving single items from the list by element number, and a Clear() method to empty the List._      

_Data is entered via a form linked to from the Index.cshtml page via a "NEW CONTACT" button. A "CLEAR" button on the Index.cshtml page lets the user Clear() the entire Contact List. The entire Contact List is displayed via Razor on the Index.cshtml as per instructions for the project._

_The root path of the project is "/" (in this case, Localhost:5000)._

### The following specs are included in the program:

* Create a project directory as well as ones for Model, View, and Controller.

* Create basic files including the .csproj, Startup, and Program files.

* Display an Index page

* Create a Contact class

* Create an instance of one Contact

* Display the Contact on the Index page

* Create a Contact List with two Contacts added to it

* Display the Contact List on the Index page

* Create a View called CreateForm with a form that will take a Contact with a SUBMIT button and Post action.<--

* Have the controller add that Contact info to the List of objects

* Display the Contact List on the Index page.


* Refactor code.

* Add CSS and Javascript via Bootstrap to all .cshtml files

* Add a Find() method

* Add a form to ask for a Search query

* Add a route to the Find() method and enable the search

* IF TIME PERMITS:
  - ADD A DELETE() METHOD
  - SEPARATE THE ADDRESS FROM THE CONTACT NAME

## Setup/Installation Requirements

* Download the files from the repository into appropriately named directories.
* Dotnet build the project
* Dotnet run the program.

## Known Bugs

_There are no known issues at this time. However, the program does not validate form input._

## Support and contact details

_You can contact me at:_

* andy.grossberg@gmail.com

## Technologies Used

_Uses HTML, CSS, C# and .Net._

### License

*Distributed under the GPL*

Copyright (c) 2018 **_Andy Grossberg_**
