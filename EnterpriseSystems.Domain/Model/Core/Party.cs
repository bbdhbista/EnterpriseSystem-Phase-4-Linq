
namespace EnterpriseSystems.Domain.Model.Core
{
    public abstract class Party
    {
        public string Name { get; private set; }
        public Address Address { get; private set; }

        protected Party(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
