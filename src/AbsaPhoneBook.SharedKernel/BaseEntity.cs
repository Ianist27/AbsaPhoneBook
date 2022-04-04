using System;
using System.Collections.Generic;

namespace AbsaPhoneBook.SharedKernel
{
    // This can be modified to BaseEntity<TId> to support multiple key types (e.g. Guid)
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}