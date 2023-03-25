using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPJ_Application.Dtos
{
    public class RootResponse
    {
        public string Cnpj { get; set; }
        public int IdentificadorMatrizFilial { get; set; }
        public string DescricaoMatrizFilial { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int SituacaoCadastral { get; set; }
        public string DescricaoSituacaoCadastral { get; set; }
        public string DataSituacaoCadastral { get; set; }
        public int MotivoSituacaoCadastral { get; set; }
        public object NomeCidadeExterior { get; set; }
        public int CodigoNaturezaJuridica { get; set; }
        public string DataInicioAtividade { get; set; }
        public int CnaeFiscal { get; set; }
        public string CnaeFiscalDescricao { get; set; }
        public string DescricaoTipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public int CodigoMunicipio { get; set; }
        public string Municipio { get; set; }
        public string DddTelefone1 { get; set; }
        public object DddTelefone2 { get; set; }
        public object DddFax { get; set; }
        public int QualificacaoDoResponsavel { get; set; }
        public double CapitalSocial { get; set; }
        public string Porte { get; set; }
        public string DescricaoPorte { get; set; }
        public bool? OpcaoPeloSimples { get; set; }
        public object DataOpcaoPeloSimples { get; set; }
        public object DataExclusaoDoSimples { get; set; }
        public bool? OpcaoPeloMei { get; set; }
        public object SituacaoEspecial { get; set; }
        public object DataSituacaoEspecial { get; set; }
        public List<CnaesSecundarioResponse> CnaesSecundarios { get; set; }
        public List<QsaResponse> Qsa { get; set; }
    }
}
