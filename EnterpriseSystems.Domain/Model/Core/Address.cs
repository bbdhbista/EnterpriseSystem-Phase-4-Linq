using System.Collections.Generic;

namespace EnterpriseSystems.Domain.Model.Core
{
    public class Address
    {
        public IList<string> AddressLines { get; private set; }
        public string City { get; private set; }
        public string StateCode { get; private set; }
        public string PostalCode { get; private set; }

        public Address(string addressLine1, string addressLine2, string city, string stateCode, string postalCode)
        {
            AddressLines = new List<string> { addressLine1, addressLine2 }.AsReadOnly();
            City = city;
            StateCode = stateCode;
            PostalCode = postalCode;
        }
    }

}
