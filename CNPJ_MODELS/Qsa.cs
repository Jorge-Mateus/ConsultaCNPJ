﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CNPJ_MODELS
{
    public class Qsa
    {
        [JsonPropertyName("identificador_de_socio")]
        public int IdentificadorDeSocio { get; set; }

        [JsonPropertyName("nome_socio")]
        public string NomeSocio { get; set; }

        [JsonPropertyName("cnpj_cpf_do_socio")]
        public string CnpjCpfDoSocio { get; set; }

        [JsonPropertyName("codigo_qualificacao_socio")]
        public int CodigoQualificacaoSocio { get; set; }

        [JsonPropertyName("percentual_capital_social")]
        public int PercentualCapitalSocial { get; set; }

        [JsonPropertyName("data_entrada_sociedade")]
        public string DataEntradaSociedade { get; set; }

        [JsonPropertyName("cpf_representante_legal")]
        public object CpfRepresentanteLegal { get; set; }

        [JsonPropertyName("nome_representante_legal")]
        public object NomeRepresentanteLegal { get; set; }

        [JsonPropertyName("codigo_qualificacao_representante_legal")]
        public object CodigoQualificacaoRepresentanteLegal { get; set; }
    }
}
