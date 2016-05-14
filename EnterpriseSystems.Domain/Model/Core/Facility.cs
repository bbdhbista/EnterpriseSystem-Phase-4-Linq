
namespace EnterpriseSystems.Domain.Model.Core
{
    public class Facility : Party
    {
        public Facility(string name, Address address)
            : base(name, address)
        {
        }
    }
}
