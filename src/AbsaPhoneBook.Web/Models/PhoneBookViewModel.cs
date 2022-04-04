using System.Collections.Generic;

namespace AbsaPhoneBook.Web.Models
{
    public class PhoneBookViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public List<EntryViewModel> Entries = new();
    }
}
