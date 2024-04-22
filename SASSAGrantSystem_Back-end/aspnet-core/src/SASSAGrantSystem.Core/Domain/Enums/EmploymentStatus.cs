using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASSAGrantSystem.Domain.Enums
{
    public enum EmploymentStatus : int
    {
        [Description("Unemployed")]
        Unemployed = 1,

        [Description("Currently Employed")]
        CurrentlyEmployed = 2,

        [Description("Self-Employed")]
        SelfEmployed = 3,

        [Description("Retired")]
        Retired = 4
    }
}
