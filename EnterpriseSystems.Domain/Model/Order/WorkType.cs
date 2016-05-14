
using System.Collections;
using System.Collections.Generic;

namespace EnterpriseSystems.Domain.Model.Order
{
    public class WorkType
    {
        public static readonly WorkType Builder = new WorkType(WorkCodes.Builder);
        public static readonly WorkType Home = new WorkType(WorkCodes.Home);
        public static readonly WorkType Retail = new WorkType(WorkCodes.Retail);

        private string workCode;

        public WorkType(string workCode)
        {
            this.workCode = workCode;
        }

        public static bool operator ==(WorkType workType1, WorkType workType2)
        {
            return (workType1.workCode == workType2.workCode);
        }

        public static bool operator !=(WorkType workType1, WorkType workType2)
        {
            return (workType1.workCode != workType2.workCode);
        }

        public override string ToString()
        {
            return this.workCode;
        }
    }
}
