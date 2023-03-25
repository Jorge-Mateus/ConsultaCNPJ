using CNPJ_Application.Dtos;
using CNPJ_MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ_Application.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenerics<Root>> BuscarCNPJ(string cnpj);
        //Task<ResponseGenerics<Root>> AdcBuscarCNPJ(string cnpj);
    }
}
