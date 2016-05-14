using System;

namespace EnterpriseSystems.Domain.Model.Order
{
    public class OrderNumber : IEquatable<OrderNumber>
    {
        private string orderNumber;

        public OrderNumber(string orderNumber)
        {
            this.orderNumber = orderNumber;
        }

        public bool Equals(OrderNumber other)
        {
            return (this.orderNumber == other.orderNumber);
        }

        public override string ToString()
        {
            return this.orderNumber;
        }
    }

}
