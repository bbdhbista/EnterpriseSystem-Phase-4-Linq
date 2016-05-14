namespace EnterpriseSystems.Domain.Model.Core
{
    public class Customer : Party
    {
        public Customer(string name, Address address)
            : base(name, address)
        {
        }
    }
}
