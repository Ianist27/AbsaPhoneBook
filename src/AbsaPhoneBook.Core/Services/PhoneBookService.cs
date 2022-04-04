using AbsaPhoneBook.Core.Interfaces;
using AbsaPhoneBook.Core.ProjectAggregate;
using AbsaPhoneBook.Core.ProjectAggregate.Specifications;
using AbsaPhoneBook.SharedKernel.Dto;
using AbsaPhoneBook.SharedKernel.Interfaces;
using Ardalis.GuardClauses;
using Ardalis.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsaPhoneBook.Core.Services
{
    public class PhoneBookService : IPhoneBookService
    {
        private readonly IRepository<Entry> _repoEntry;
        private readonly IRepository<PhoneBook> _repoPhoneBook;
        

        public PhoneBookService(IRepository<Entry> repoEntry, IRepository<PhoneBook> repository)
        {
            _repoEntry = repoEntry;
            _repoPhoneBook = repository;
        }

        public async Task<Result<PhoneBook>> AddPhoneBookAsync(PhoneBook phoneBook)
        {
            var spec = new PhoneBookByNameSpec(phoneBook.Name);

            var existingPhoneBook = await _repoPhoneBook.GetBySpecAsync(spec);

            if (existingPhoneBook != null)
            {
                existingPhoneBook.Entries.AddRange(phoneBook.Entries);

                await _repoPhoneBook.UpdateAsync(existingPhoneBook);

                return existingPhoneBook;
            }
            else
            {
               phoneBook = await _repoPhoneBook.AddAsync(phoneBook);
            }

            return phoneBook;
        }

        public async Task<Result<List<PhoneBook>>> GetAllPhoneBookAsync()
        {
            var res = await _repoPhoneBook.ListAsync();

            if (res == null || !res.Any())
                return Result<List<PhoneBook>>.NotFound();

            //Get Entries
            foreach (var phoneBook in res)
            {
                var spec = new EntryByNameSpec(phoneBook.Name);
                var entries = await _repoEntry.ListAsync(spec);

                phoneBook.Entries = entries;  
            }

            return res;
        }

        public async Task<Result<List<PhoneBook>>> GetPhoneBookByNameAsync(string searchString)
        {
            var spec = new SearchPhoneBookByNameSpec(searchString);

            var phoneBooks = await _repoPhoneBook.ListAsync(spec);

            if (phoneBooks == null || !phoneBooks.Any())
                return Result<List<PhoneBook>>.NotFound();

            foreach (var phoneBook in phoneBooks)
            {
                var entrySpec = new EntryByNameSpec(phoneBook.Name);
                var entries = await _repoEntry.ListAsync(entrySpec);
                phoneBook.Entries = entries;
            }

            return phoneBooks;
        }

        public Task<Result<PhoneBook>> UpdatePhoneBookAsync(PhoneBook phoneBook)
        {
            throw new NotImplementedException();
        }

        public Task<Result<int>> DeletePhoneBookAsync(PhoneBook phoneBook)
        {
            throw new NotImplementedException();
        }
    }
}
