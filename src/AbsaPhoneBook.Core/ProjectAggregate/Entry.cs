
using AbsaPhoneBook.SharedKernel;
using AbsaPhoneBook.SharedKernel.Interfaces;

namespace AbsaPhoneBook.Core.ProjectAggregate
{
    public class Entry : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

    }
}
