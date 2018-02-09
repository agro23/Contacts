using System.Collections.Generic;

namespace Contacts.Models
{
  public class Contact
  {
    // private string _id;
    private string _first;
    private string _last;
    private string _address1;
    private string _address2;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private string _phone;
    private static List<Contact> _instances = new List<Contact> {};
    private int _id;

    public Contact (string firstName, string lastName, string anAddress1, string anAddress2, string aCity, string aStateOrProvince, string aCountry, string aPhone)
    {
      _first = firstName;
      _last = lastName;
      _address1 = anAddress1;
      _address2 = anAddress2;
      _city = aCity;
      _stateOrProvince = aStateOrProvince;
      _country = aCountry;
      _phone = aPhone;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetFirstname()
    {
      return _first;
    }
    public void SetFirstname(string newFirst)
    {
      _first = newFirst;
    }
// The above Getter and Setter should be the model for all of them!
// When the form is sent, ALL of the setters will be called in the controller at the path.
// When the Index shows the list, only the first and last will retrieve via the getter and produce a string in the LI.
// HOWEVER, it will link to the ID number of that Contact from the list.

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Contact Find(int myID)
    {
      return _instances[myID-1];
    }

  }
}
