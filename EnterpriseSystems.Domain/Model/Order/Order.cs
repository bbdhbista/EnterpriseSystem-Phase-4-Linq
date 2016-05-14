using EnterpriseSystems.Domain.Model.Core;

namespace EnterpriseSystems.Domain.Model.Order
{
    public class Order
    {
        public OrderNumber OrderNumber { get; set; }
        public Party Origin { get; set; }
        public Party Destination { get; set; }
        public WorkType WorkType { get; set; }
        public LegType LegType { get; set; }
        public Scheduled Scheduled { get; set; }
        public string Project { get; set; }
    }
}
