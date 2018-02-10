using System.Collections.Generic;

namespace Contacts.Models
{
  public class Contact
  {
    // private string _id;
    private string _first;
    private string _last;
    private string _company;
    private string _address1;
    private string _address2;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private string _postalCode;
    private string _phone;
    private static List<Contact> _instances = new List<Contact> {};
    private int _id;

    public Contact (string firstName, string lastName, string aCompany, string anAddress1, string anAddress2, string aCity, string aStateOrProvince, string aCountry, string aPostal, string aPhone)
    {
      _first = firstName;
      _last = lastName;
      _company = aCompany;
      _address1 = anAddress1;
      _address2 = anAddress2;
      _city = aCity;
      _stateOrProvince = aStateOrProvince;
      _country = aCountry;
      _postalCode = aPostal;
      _phone = aPhone;
      _instances.Add(this);
      _id = _instances.Count;
    }

// GETTERS and SETTERS

    public string GetFirstName()
    {
      return _first;
    }
    public void SetFirstName(string newFirst)
    {
      _first = newFirst;
    }
    public string GetLastName()
    {
      return _last;
    }
    public void SetLastName(string newLast)
    {
      _last = newLast;
    }
    public string GetCompany()
    {
      return _company;
    }
    public void SetCompany(string newCompany)
    {
      _company = newCompany;
    }
    public string GetAddress1()
    {
      return _address1;
    }
    public void SetAddress1(string newAddress1)
    {
      _address1 = newAddress1;
    }
    public string GetAddress2()
    {
      return _address2;
    }
    public void SetAddress2(string newAddress2)
    {
      _address2 = newAddress2;
    }
    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }
    public string GetStateOrProvince()
    {
      return _stateOrProvince;
    }
    public void SetStateOrProvince(string newStateOrProvince)
    {
      _stateOrProvince = newStateOrProvince;
    }
    public string GetCountry()
    {
      return _country;
    }
    public void SetCountry(string newCountry)
    {
      _city = newCountry;
    }
    public string GetPostalCode()
    {
      return _postalCode;
    }
    public void SetPostalCode(string newPostalCode)
    {
      _postalCode = newPostalCode;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    public int GetID()
    {
      return _id;
    }
    // NO set ID because the Contact is managing the ID itself along with the GetAll List.

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
