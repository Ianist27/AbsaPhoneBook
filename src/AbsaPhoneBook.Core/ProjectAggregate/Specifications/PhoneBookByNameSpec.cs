using AbsaPhoneBook.Core.ProjectAggregate;
using Ardalis.Specification;

namespace AbsaPhoneBook.Core.ProjectAggregate.Specifications
{
    public class PhoneBookByNameSpec : Specification<PhoneBook>, ISingleResultSpecification
    {
        public PhoneBookByNameSpec(string name)
        {
            Query
                .Where(x => x.Name == name)
                .Include(x => x.Entries);
        }
    }
}
