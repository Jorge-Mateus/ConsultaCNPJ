using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ_Application.Dtos
{
    public class QsaResponse
    {
        public int IdentificadorDeSocio { get; set; }
        public string NomeSocio { get; set; }
        public string CnpjCpfDoSocio { get; set; }
        public int CodigoQualificacaoSocio { get; set; }
        public int PercentualCapitalSocial { get; set; }
        public string DataEntradaSociedade { get; set; }
        public object CpfRepresentanteLegal { get; set; }
        public object NomeRepresentanteLegal { get; set; }
        public object CodigoQualificacaoRepresentanteLegal { get; set; }
    }
}
