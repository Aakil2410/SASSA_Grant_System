using Abp.Domain.Entities.Auditing;
using System;

namespace SASSAGrantSystem.Domain
{
    public class Grant : FullAuditedEntity<Guid>
    {
        public virtual string GrantType { get; set; }
        public virtual string Description { get; set; }
        public virtual string GrantAmount { get; set; }

    }
    }
}
