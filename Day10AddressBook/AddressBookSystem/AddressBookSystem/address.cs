using System;

class Address
{
    public string name;
 
    public string address;
    public string city;
    public string state;
    public string zip;
    public string phoneNumber;
    public string email;


    public Address(string name, string address, string city, string state, string zip, string phoneNumber, string email)
    {
        this.name = name;
 
        this.address = address;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }
}