using System;
using AutoMapper;

using CoverAll_API.A_UI.ViewModel;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.A_UI.Config
{
    public class AutoMapperConfig : Profile
    {
         public AutoMapperConfig()
        {
            CreateMap<ProdutoVM,Produto>().ReverseMap();
            CreateMap<ClienteVM,Cliente>().ReverseMap();
            CreateMap<LoginVM,Login>().ReverseMap();

        }
    }
}
