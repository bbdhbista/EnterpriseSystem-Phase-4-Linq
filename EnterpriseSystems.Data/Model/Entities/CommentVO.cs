using System;

namespace EnterpriseSystems.Data.Model.Entities
{
    public class CommentVO
    {
        public int Identity { get; set; }
        public string EntityName { get; set; }
        public int EntityIdentity { get; set; }
        public short SequenceNumber { get; set; }
        public string CommentType { get; set; }
        public string CommentText { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUserId { get; set; }
        public string CreatedProgramCode { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string LastUpdatedUserId { get; set; }
        public string LastUpdatedProgramCode { get; set; }
    }
}
