using AbsaPhoneBook.Core.ProjectAggregate;
using AutoMapper;

namespace AbsaPhoneBook.API.MappingConfiguration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SharedKernel.Dto.PhonebookDto, PhoneBook>();
            CreateMap<PhoneBook, SharedKernel.Dto.PhonebookDto>();
            
            CreateMap<SharedKernel.Dto.EntryDto, Entry>();
            CreateMap<Entry, SharedKernel.Dto.EntryDto>();
        }
    }
}
