namespace EnterpriseSystems.Domain.Model.Core
{
    public class AppointmentFunctionTypes
    {
        public const string DeliveryAppointment = "DELV_APPT";
        public const string Drop = "DROP";
        public const string Final = "FINAL";
        public const string Fulfillment = "FULFILL";
        public const string OrderPost = "ORDERPOST";
        public const string PickupAppointment = "PU_APPT";
        public const string PoDate = "PODATE";
        public const string ShipFrom = "SHIPFROM";
        public const string ShipTo = "SHIPTO";
        public const string Target = "TARGET";
        public const string VendorShip = "VNDSHIP";
        public const string InboundEta = "INBOUNDETA";
        public const string Inbound = "INBOUND";
        public const string Eta = "ETA";
        public const string RequestedFinal = "REQ_FINAL";
        public const string Offered = "OFFERED";
    }

    public class CommentTypes
    {
        public const string Approver = "APPRCOMMNT";
        public const string Order = "ORDER";
        public const string OrderUpdate = "ORDUPD";
        public const string Driver = "DRIVER";
        public const string Customer = "CUSTOMER";
        public const string Delivery = "DELIVERY";
    }

    public class ConsumerClassificationTypes
    {
        public const string BuilderDirect = "BLDRDIRECT";
        public const string BuilderIndirect = "BLDRINDRCT";
        public const string Residential = "HOMEDELVR";
        public const string Retail = "RETAIL";
        public const string ThirdParty = "THIRDPARTY";
    }

    public class ProcessStatus
    {
        public const string Canceled = "CANCELED";
        public const string Complete = "COMPLETE";
        public const string Hold = "ORDERHOLD";
        public const string InProcess = "INPROCESS";
        public const string Pending = "PENDING";
    }

    public class ProjectCodes
    {
        public const string Arkansas = "UARK";
        public const string Southeastern = "SELU";
        public const string Unknown = "UNKN";
    }

    public class ReferenceNumberTypes
    {
        public const string AccountNumber = "ACCT NBR";
        public const string BackOrderNumber = "BO NBR";
        public const string BillOfLading = "BOL";
        public const string CarrierCode = "CARRIER CD";
        public const string CartonNumber = "CARTON";
        public const string CommitmentNumber = "COMMIT NBR";
        public const string Contractor = "CONTRACTOR";
        public const string CustomerHierarchyNumber = "CUS_HIER_N";
        public const string CustomerOrderNumber = "CUST PO";
        public const string DocumentIdentifier = "DOC ID";
        public const string EquipmentNumber = "EQUIP NBR";
        public const string ExchangeNumber = "EXCHANGE";
        public const string GroupOrderNumber = "GRP NBR";
        public const string LoadNumber = "LOADNBR";
        public const string LoadType = "LD_TYP";
        public const string ManifestId = "MANIFESTID";
        public const string MasterBolNumber = "MBOL";
        public const string MasterSku = "MASTER SKU";
        public const string Network = "NETWORK";
        public const string OrderStatus = "ORDER STT";
        public const string OrderType = "ORDER TYP";
        public const string PurchaseOrderNumber = "PO NBR";
        public const string Pool = "POOL NBR";
        public const string ProductType = "PROD TYP";
        public const string ProNumber = "PRO NBR";
        public const string ReferenceGroup = "REF GRP";
        public const string ReleaseNumber = "RLS NBR";
        public const string ReturnNumber = "RETURN NBR";
        public const string ScheduleNumber = "SCHED NBR";
        public const string ShipmentDestinationCode = "STPCLSTYP";
        public const string ShippingCondition = "SHP_STO_GI";
        public const string ShuttleBolNumber = "SHUTTLEBOL";
        public const string ShipId = "SHIPID";
        public const string SoldToCustomerNumber = "SOLD_TO";
        public const string StopNumber = "STOP NBR";
        public const string StoreNumber = "STORE NBR";
        public const string VendorNumber = "VENDOR NBR";
        public const string VoyageNumber = "VOYAGE NBR";
    }

    public class StopRoleTypes
    {
        public const string BillTo = "BILL TO";
        public const string Installer = "INSTALLER";
        public const string InstallerPickup = "INSTL PKUP";
        public const string LDC = "LDC";
        public const string RDC = "RDC";
        public const string Receiver = "RECEIVER";
        public const string Shipper = "SHIPPER";
        public const string ShippingFrom = "SHIPPING FROM";
        public const string ShipTo = "SHIP TO";
        public const string Solicitor = "SOLICITOR";
        public const string WillCall = "WILLCALL";
        public const string XDock = "XDOCK";
    }
}
