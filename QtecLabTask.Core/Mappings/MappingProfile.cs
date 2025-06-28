using AutoMapper;
using QtecLabTask.Core.DTOs;
using QtecLabTask.Core.Entities;


namespace QtecLabTask.Core.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {
            CreateMap<Account, AccountDto>().ReverseMap();
        }
    }
}
