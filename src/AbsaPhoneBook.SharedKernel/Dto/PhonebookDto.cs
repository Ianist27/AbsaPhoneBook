using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaPhoneBook.SharedKernel.Dto
{
    public class PhonebookDto : BaseDto
    {
        public string Name { get; set; }

        public List<EntryDto> Entries = new();
    }
}
