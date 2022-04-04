

using AbsaPhoneBook.SharedKernel.Dto;

namespace AbsaPhoneBook.Web.Models
{
    public class EntryViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public static EntryViewModel FromEntry(EntryDto entry)
        {
            return new EntryViewModel()
            {
                Id = entry.Id,
                Name = entry.Name,
                PhoneNumber = entry.PhoneNumber
            };
        }
    }
}
