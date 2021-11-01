using System;
using System.Collections.Generic;


class AddressBook
{
    List<Address> addresses;

    public AddressBook()
    {
        addresses = new List<Address>();
    }

    public bool add(string name, string address, string city, string state, string zip, string phoneNumber, string email)
    {
        Address addr = new Address(name, address, city, state, zip, phoneNumber, email);
        Address result = find(name);
        //if (book.add(name, address, city, state, zip, phoneNumber, email))

        if (result == null)
        {
            addresses.Add(addr);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool remove(string name)
    {
        Address addr = find(name);

        if (addr != null)
        {
            addresses.Remove(addr);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void list(Action<Address> action)
    {
        addresses.ForEach(action);
    }

    public bool isEmpty()
    {
        return (addresses.Count == 0);
    }

    public Address find(string name)
    {
        Address addr = addresses.Find(
          delegate (Address a) {
              return a.name == name;
          }
        );
        return addr;
    }


}