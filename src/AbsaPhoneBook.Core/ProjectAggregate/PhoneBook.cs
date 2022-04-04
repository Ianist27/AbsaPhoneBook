using AbsaPhoneBook.SharedKernel;
using AbsaPhoneBook.SharedKernel.Interfaces;
using Ardalis.GuardClauses;
using System.Collections.Generic;
using System.Linq;

namespace AbsaPhoneBook.Core.ProjectAggregate
{
    public class PhoneBook : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }

        public List<Entry> Entries { get; set; }
    }
}
