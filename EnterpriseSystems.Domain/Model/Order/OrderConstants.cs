
namespace EnterpriseSystems.Domain.Model.Order
{
    public class WorkCodes
    {
        public const string Builder = "BD";
        public const string Home = "H";
        public const string Retail = "L";
    }

    public enum LegType
    {
        Delivery,
        Pickup
    }
}
