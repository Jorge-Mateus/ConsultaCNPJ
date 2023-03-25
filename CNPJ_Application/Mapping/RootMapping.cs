using AutoMapper;
using CNPJ_Application.Dtos;
using CNPJ_MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ_Application.Mapping
{
    public class RootMapping : Profile
    {
        public RootMapping()
        {
            CreateMap(typeof(ResponseGenerics<>), typeof(ResponseGenerics<>));
            CreateMap<RootResponse, Root>();
            CreateMap<Root, RootResponse>();
            CreateMap<Qsa, QsaResponse>();
            CreateMap<QsaResponse, Qsa>();
            CreateMap<CnaesSecundarioResponse, CnaesSecundario>();
            CreateMap<CnaesSecundario, CnaesSecundarioResponse>();
        }
    }
}
