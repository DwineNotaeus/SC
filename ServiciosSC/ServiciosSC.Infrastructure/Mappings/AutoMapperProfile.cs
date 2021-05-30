using AutoMapper;
using ServiciosSC.Core.DTOs;
using ServiciosSC.Core.Entities;
using System.Collections.Generic;

namespace ServiciosSC.Infrastructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Credit, CreditDTO>();
            CreateMap<CreditDTO, Credit>();

            CreateMap<Client, ClientDTO>();
            CreateMap<ClientDTO, Client>();

            CreateMap<List<IdentificationType>, List<IdentificationTypeDTO>>();
            CreateMap<List<IdentificationTypeDTO>, List<IdentificationType>>();
        }
    }
}
