using AutoMapper;
using CNPJ_Application.Dtos;
using CNPJ_Application.Interfaces;
using CNPJ_MODELS;
using CNPJ_Persistence.Contexto;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ_Application.Application
{
    public class RootService : IRoot
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilApi;
        private readonly CnpjApiContext _cnpjApiContext;

        public RootService(IMapper mapper, IBrasilApi brasilApi, CnpjApiContext cnpjApiContext)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
            _cnpjApiContext = cnpjApiContext;
        }

        public async Task<ResponseGenerics<RootResponse>> BuscarCNPJ(string cnpj)
        {
            var cnpjs = await _brasilApi.BuscarCNPJ(cnpj);

            return _mapper.Map<ResponseGenerics<RootResponse>>(cnpjs);
        }

        public async Task<ResponseGenerics<RootResponse>> AdcBuscarCNPJ(string cnpj)
        {
            var cnpjs = await _brasilApi.BuscarCNPJ(cnpj);
            _cnpjApiContext.Add(cnpjs);
            await _cnpjApiContext.SaveChangesAsync();
            return null;
            
        }
    }
}
