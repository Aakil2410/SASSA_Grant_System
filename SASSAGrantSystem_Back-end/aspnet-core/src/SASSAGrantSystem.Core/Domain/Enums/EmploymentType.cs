using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSAGrantSystem.Domain.Enums
{
    public enum EmploymentType : int
    {
        [Description("Full-Time")]
        FullTime = 1,

        [Description("Part-Time")]
        PartTime = 2,

        [Description("Temporary")]
        Temporary = 3,

        [Description("Contract")]
        Contract = 4,

        [Description("Casual")]
        Casual = 5
    }
}
