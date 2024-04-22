using Abp.Domain.Entities.Auditing;
using SASSAGrantSystem.Authorization.Users;
using SASSAGrantSystem.Domain.Enums;
using System;

namespace SASSAGrantSystem.Domain
{
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual string FullName { get; set; }

        public virtual DateTime DateOfBirth { get; set; }

        public virtual Gender? Gender { get; set; }

        public virtual string IDNumber { get; set; }

        public virtual string Email { get; set; }

        public virtual string Password { get; set; }

        public virtual string ContactNumber { get; set; }

        public virtual string Address { get; set; }

        public virtual DateTime? RegistrationDate { get; set; }

        public virtual User User { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }
}
