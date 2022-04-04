using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsaPhoneBook.SharedKernel.Dto
{
    public class EntryDto : BaseDto
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
