    using System;

    public class Address
    {
        private string _address = "";

        public Address(string addy)
        {
            _address = addy;
        }

        public Address()
        {
        }

        public string GetAddress()
        {
            string addy = _address;
            return addy;
        }

        public void SetAddress(string addy)
        {
            _address = addy;
        }
        
    }