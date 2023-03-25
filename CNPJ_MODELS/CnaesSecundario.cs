using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace CNPJ_MODELS
{
    public class CnaesSecundario
    {
        [JsonPropertyName("codigo")]
        public int Codigo { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }
    }
}
