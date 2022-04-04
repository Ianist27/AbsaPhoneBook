using AbsaPhoneBook.Core.ProjectAggregate;
using AbsaPhoneBook.SharedKernel.Dto;
using Ardalis.Result;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbsaPhoneBook.Core.Interfaces
{
    public interface IPhoneBookService
    {
        Task<Result<PhoneBook>> AddPhoneBookAsync(PhoneBook phoneBook);
        Task<Result<PhoneBook>> UpdatePhoneBookAsync(PhoneBook phoneBook);
        Task<Result<List<PhoneBook>>> GetAllPhoneBookAsync();
        Task<Result<List<PhoneBook>>> GetPhoneBookByNameAsync(string searchString);
        Task<Result<int>> DeletePhoneBookAsync(PhoneBook phoneBook);

    }
}
