using System;
using System.Collections.Generic;

namespace EnterpriseSystems.Data.Model.Entities
{
    public class CustomerRequestVO
    {
        public CustomerRequestVO()
        {
            Appointments = new List<AppointmentVO>();
            Comments = new List<CommentVO>();
            ReferenceNumbers = new List<ReferenceNumberVO>();
            Stops = new List<StopVO>();
        }

        public int Identity { get; set; }
        public string Status { get; set; }
        public string BusinessEntityKey { get; set; }
        public string TypeCode { get; set; }
        public string ConsumerClassificationType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUserId { get; set; }
        public string CreatedProgramCode { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedUserId { get; set; }
        public string LastUpdatedProgramCode { get; set; }

        public List<AppointmentVO> Appointments { get; set; }
        public List<CommentVO> Comments { get; set; }
        public List<ReferenceNumberVO> ReferenceNumbers { get; set; }
        public List<StopVO> Stops { get; set; }
    }
}
