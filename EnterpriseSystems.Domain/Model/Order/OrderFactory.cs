using System;
using System.Collections.Generic;
using System.Linq;
using EnterpriseSystems.Data.Model.Entities;
using EnterpriseSystems.Domain.Model.Core;

namespace EnterpriseSystems.Domain.Model.Order
{
    public class OrderFactory : IOrderFactory
    {
        public static OrderFactory orderFactory = new OrderFactory();
        private OrderFactory() { }

        public static OrderFactory GetInstance() => orderFactory;

        public Order Create(CustomerRequestVO customerRequest) => customerRequest == null ? null : new Order
        {
            OrderNumber = SetOrderNumberFromReferenceNumber(customerRequest.ReferenceNumbers),
            Origin = customerRequest.Stops.Any() ? SetOrderOriginFromStopVO(customerRequest.Stops.First()) : null,
            Destination = customerRequest.Stops.Any() ? SetOrderDestinationFromStopVO(customerRequest.Stops.Last()) : null,
            Scheduled = customerRequest.Appointments.Count < 2 ? Scheduled.Empty : SetSchedule(customerRequest.Appointments.Last()),
            Project = customerRequest.BusinessEntityKey ?? string.Empty,
            WorkType = string.IsNullOrEmpty(customerRequest.ConsumerClassificationType) ? null : SetWorkTypeFromConsumerClassificationType(customerRequest.ConsumerClassificationType),
            LegType = customerRequest.Stops.Any() ? SetLegtype(customerRequest.Stops.Last()) : LegType.Pickup,
        };

        private OrderNumber SetOrderNumberFromReferenceNumber(List<ReferenceNumberVO> referenceNumbers)
         => referenceNumbers.Any() ? new OrderNumber((from reference in referenceNumbers
                                                      where reference.ReferenceNumberType.Equals(ReferenceNumberTypes.BillOfLading)
                                                      select reference.ReferenceNumber).Last())
                                 : null;

        private Party SetOrderOriginFromStopVO(StopVO stopVo) => new Facility(stopVo.OrganizationName,
           new Address(stopVo.AddressLine1 ?? string.Empty,
                stopVo.AddressLine2 ?? string.Empty ,
                stopVo.AddressCityName ?? string.Empty,
                stopVo.AddressStateCode ?? string.Empty ,
                stopVo.AddressPostalCode ?? string.Empty 
                )
            );

        private Party SetOrderDestinationFromStopVO(StopVO stopVo) => new Customer(stopVo.OrganizationName,
                new Address(stopVo.AddressLine1,
                stopVo.AddressLine2 ?? string.Empty ,
                stopVo.AddressCityName ??  string.Empty,
                stopVo.AddressStateCode ?? string.Empty,
                stopVo.AddressPostalCode ?? string.Empty
               )
            );

        private WorkType SetWorkTypeFromConsumerClassificationType(String consumerClassificationType)
        {
            List<string> builder = new List<string> { ConsumerClassificationTypes.BuilderDirect, ConsumerClassificationTypes.BuilderIndirect };
            List<string> home = new List<string> { ConsumerClassificationTypes.Residential };

            return (builder.Contains(consumerClassificationType)) ? WorkType.Builder
               : home.Contains(consumerClassificationType)
                    ? WorkType.Home
                       : WorkType.Retail;
        }

        private LegType SetLegtype(StopVO stopVo)
        {
            if (string.IsNullOrEmpty(stopVo.RoleType)) return LegType.Pickup;
            else
            {
                List<string> delivery = new List<string>
                {
                    StopRoleTypes.BillTo,
                    StopRoleTypes.ShipTo,
                    StopRoleTypes.Shipper,
                    StopRoleTypes.Shipper
                };
                return (delivery.Contains(stopVo.RoleType)) ? LegType.Delivery : LegType.Pickup;
            }
        }

        private Scheduled SetSchedule(AppointmentVO appointmentVo) =>
            new Scheduled(appointmentVo.AppointmentBegin.GetValueOrDefault(),
            appointmentVo.AppointmentEnd.GetValueOrDefault());
    }
}
