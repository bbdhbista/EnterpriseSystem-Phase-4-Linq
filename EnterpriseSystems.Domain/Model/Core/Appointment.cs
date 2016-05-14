using System;

namespace EnterpriseSystems.Domain.Model.Core
{
    public class Scheduled
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        public static readonly Scheduled Empty = new Scheduled(DateTime.MinValue, DateTime.MaxValue);

        public Scheduled(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public bool IsEmpty()
        {
            return (this == Empty);
        }
    }

}
