using Abp.Domain.Entities.Auditing;
using SASSAGrantSystem.Domain.Enums;
using System;

namespace SASSAGrantSystem.Domain
{
    public class Employment : FullAuditedEntity<Guid>
    {
        public virtual string TaxNumber { get; set; }

        public virtual EmploymentStatus Status { get; set; }

        public virtual Person Person { get; set; }

    }
}
