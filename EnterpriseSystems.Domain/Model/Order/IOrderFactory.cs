using EnterpriseSystems.Data.Model.Entities;

namespace EnterpriseSystems.Domain.Model.Order
{
    public interface IOrderFactory
    {
        Order Create(CustomerRequestVO customerRequest);
    }
}
