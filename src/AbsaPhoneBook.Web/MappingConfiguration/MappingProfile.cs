using AbsaPhoneBook.SharedKernel.Dto;
using AbsaPhoneBook.Web.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsaPhoneBook.Web.MappingConfiguration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PhonebookDto, PhoneBookViewModel>();
            CreateMap<PhoneBookViewModel, PhonebookDto>();

            CreateMap<EntryDto, EntryViewModel>();
            CreateMap<EntryViewModel, EntryDto>();
        }
        
    }
}
