using EnterpriseSystems.Domain.Model.Core;
using System.Collections.Generic;

namespace EnterpriseSystems.Domain.Model.Order
{
    public interface IOrderRepository
    {
        IEnumerable<Order> FindByScheduledAndFacility(Scheduled scheduled, Facility facility);
        IEnumerable<Order> FindByOrderNumber(OrderNumber orderNumber);
    }
}
