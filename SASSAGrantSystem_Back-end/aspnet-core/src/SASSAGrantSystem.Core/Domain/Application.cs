using Abp.Domain.Entities.Auditing;
using System;

namespace SASSAGrantSystem.Domain
{
    public class Application : FullAuditedEntity<Guid>
    {



        public virtual DateTime? ApplicationDate { get; set; }

        //status

        public virtual Person Person { get; set; }

        public virtual Grant Grant { get; set; }
    }
}
