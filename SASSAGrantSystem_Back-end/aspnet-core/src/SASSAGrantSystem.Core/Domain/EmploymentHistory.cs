using Abp.Domain.Entities.Auditing;
using SASSAGrantSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSAGrantSystem.Domain
{
    public class EmploymentHistory : FullAuditedEntity<Guid>
    {
        public virtual string JobTitle { get; set; }

        public virtual string Employer { get; set; }

        public virtual string Industry_Sector { get; set; }

        public virtual EmploymentType EmploymentType { get; set; }

        public virtual DateTime? StartDate { get; set; }

        public virtual DateTime? EndDate {get; set;}

        // Status >> retrenched

        public virtual decimal? Income { get; set; }

        public virtual string Location { get; set; }

        public virtual string[] Benefits { get; set; }

        public virtual Employment Employment { get; set; }

        //public virtual Person Person { get; set; }
    }
}
