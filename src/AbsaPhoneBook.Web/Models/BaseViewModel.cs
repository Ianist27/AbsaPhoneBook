using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsaPhoneBook.Web.Models
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
    }
}
