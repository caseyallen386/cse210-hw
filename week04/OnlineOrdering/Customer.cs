using System;
using System.Dynamic;


public class Customer
{

    private class Address
    {
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;
        

        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _stateOrProvince = state;
            _country = country;
        }

        public bool isInUSA()
        {
            return _country == "USA" || _country == "United States" || _country == "US";
        }

        public string GetAddress()
        {
            return $"{_street}\n{_city} {_stateOrProvince}, {_country}";
        }
    }
    
    private string _name;

    private Address _address;


    public Customer(string name, string street, string city, string state, string country)
    {

        _name = name;

        _address = new Address(street, city, state, country);
        
    }

    public string CustomerName()
    {
        return _name;
    }

    public bool isInUSA()
    {
        return _address.isInUSA();
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}