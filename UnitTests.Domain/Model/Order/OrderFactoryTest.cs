using System;
using EnterpriseSystems.Data.Model.Constants;
using EnterpriseSystems.Data.Model.Entities;
using EnterpriseSystems.Domain.Model.Core;
using EnterpriseSystems.Domain.Model.Order;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Domain.Model.Order
{
    [TestClass]
    public class OrderFactoryTest
    {
        [TestMethod]
        public void GetInstance_ReturnsSingletonInstance()
        {
            Assert.IsNotNull(OrderFactory.GetInstance());
            Assert.IsInstanceOfType(OrderFactory.GetInstance(), typeof(IOrderFactory));
            Assert.AreEqual(OrderFactory.GetInstance(), OrderFactory.GetInstance());
        }

        [TestMethod]
        public void Create_SetsOrderNumber()
        {
            var customerRequest = new CustomerRequestVO();
            customerRequest.ReferenceNumbers.Add(new ReferenceNumberVO { ReferenceNumber = "1", ReferenceNumberType = ReferenceNumberTypes.PurchaseOrderNumber });
            customerRequest.ReferenceNumbers.Add(new ReferenceNumberVO { ReferenceNumber = "2", ReferenceNumberType = ReferenceNumberTypes.BillOfLading });

            var actual = OrderFactory.GetInstance().Create(customerRequest);

            Assert.AreEqual("2", actual.OrderNumber.ToString());
        }

        [TestMethod]
        public void Create_SetsOrigin()
        {
            var customerRequest = new CustomerRequestVO();
            customerRequest.Stops.Add(new StopVO { StopNumber = 1, OrganizationName = "Southeastern", AddressLine1 = "1205 N Oak Street", AddressCityName = "Hammond", AddressStateCode = "LA", AddressPostalCode = "70402" });
            customerRequest.Stops.Add(new StopVO { StopNumber = 2, OrganizationName = "Bob Smith", AddressLine1 = "555 Somewhere Ave", AddressCityName = "Nowhere", AddressStateCode = "LA", AddressPostalCode = "76543" });

            var actual = OrderFactory.GetInstance().Create(customerRequest);

            Assert.IsInstanceOfType(actual.Origin, typeof(Facility));
            Assert.AreEqual("Southeastern", actual.Origin.Name);
            Assert.AreEqual("1205 N Oak Street", actual.Origin.Address.AddressLines[0]);
            Assert.AreEqual(String.Empty, actual.Origin.Address.AddressLines[1]);
            Assert.AreEqual("Hammond", actual.Origin.Address.City);
            Assert.AreEqual("LA", actual.Origin.Address.StateCode);
            Assert.AreEqual("70402", actual.Origin.Address.PostalCode);
        }

        [TestMethod]
        public void Create_SetsDestination()
        {
            var customerRequest = new CustomerRequestVO();
            customerRequest.Stops.Add(new StopVO { StopNumber = 1, OrganizationName = "Southeastern", AddressLine1 = "1205 N Oak Street", AddressCityName = "Hammond", AddressStateCode = "LA", AddressPostalCode = "70402" });
            customerRequest.Stops.Add(new StopVO { StopNumber = 2, OrganizationName = "Bob Smith", AddressLine1 = "555 Somewhere Ave", AddressCityName = "Nowhere", AddressStateCode = "LA", AddressPostalCode = "76543" });

            var actual = OrderFactory.GetInstance().Create(customerRequest);

            Assert.IsInstanceOfType(actual.Destination, typeof(Customer));
            Assert.AreEqual("Bob Smith", actual.Destination.Name);
            Assert.AreEqual("555 Somewhere Ave", actual.Destination.Address.AddressLines[0]);
            Assert.AreEqual(String.Empty, actual.Destination.Address.AddressLines[1]);
            Assert.AreEqual("Nowhere", actual.Destination.Address.City);
            Assert.AreEqual("LA", actual.Destination.Address.StateCode);
            Assert.AreEqual("76543", actual.Destination.Address.PostalCode);
        }

        [TestMethod]
        public void Create_SetsWorkType()
        {
            var customerRequest = new CustomerRequestVO { ConsumerClassificationType = ConsumerClassificationTypes.Residential };

            var actual = OrderFactory.GetInstance().Create(customerRequest);

            Assert.AreEqual(WorkType.Home, actual.WorkType);
        }

        [TestMethod]
        public void Create_SetsLegType()
        {
            var customerRequest = new CustomerRequestVO();
            customerRequest.Stops.Add(new StopVO { StopNumber = 1 });
            customerRequest.Stops.Add(new StopVO { StopNumber = 2, RoleType = StopRoleTypes.InstallerPickup });

            var actual = OrderFactory.GetInstance().Create(customerRequest);

            Assert.AreEqual(LegType.Pickup, actual.LegType);
        }

        [TestMethod]
        public void Create_SetsScheduledWhenExists()
        {
            var customerRequest = new CustomerRequestVO();
            customerRequest.Appointments.Add(new AppointmentVO { FunctionType = AppointmentFunctionTypes.Target, AppointmentBegin = DateTime.Today, AppointmentEnd = DateTime.Today.AddDays(1) });
            customerRequest.Appointments.Add(new AppointmentVO { FunctionType = AppointmentFunctionTypes.Final, AppointmentBegin = DateTime.Today.AddDays(2), AppointmentEnd = DateTime.Today.AddDays(3) });

            var actual = OrderFactory.GetInstance().Create(customerRequest);

            Assert.AreEqual(DateTime.Today.AddDays(2), actual.Scheduled.Start);
            Assert.AreEqual(DateTime.Today.AddDays(3), actual.Scheduled.End);
        }

        [TestMethod]
        public void Create_SetsScheduledEmptyWhenNotExists()
        {
            var customerRequest = new CustomerRequestVO();
            customerRequest.Appointments.Add(new AppointmentVO { FunctionType = AppointmentFunctionTypes.Target, AppointmentBegin = DateTime.Today, AppointmentEnd = DateTime.Today.AddDays(1) });

            var actual = OrderFactory.GetInstance().Create(customerRequest);

            Assert.AreEqual(Scheduled.Empty, actual.Scheduled);
        }

        [TestMethod]
        public void Create_SetsProject()
        {
            var customerRequest = new CustomerRequestVO { BusinessEntityKey = ProjectCodes.Southeastern };

            var actual = OrderFactory.GetInstance().Create(customerRequest);

            Assert.AreEqual(ProjectCodes.Southeastern, actual.Project);
        }
    }
}
