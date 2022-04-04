using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaPhoneBook.Core.ProjectAggregate.Specifications
{
    public class SearchPhoneBookByNameSpec : Specification<PhoneBook>
    {
        public SearchPhoneBookByNameSpec(string name)
        {
            Query.Where(x => x.Name.Contains(name));
        }
    }
}
