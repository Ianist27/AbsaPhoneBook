using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaPhoneBook.Core.ProjectAggregate.Specifications
{
    public class EntryByNameSpec : Specification<Entry>
    {
        public EntryByNameSpec(string name)
        {
            Query.Where(x => x.Name == name);
        }
    }
}
