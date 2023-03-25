using CNPJ_Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CNPJ_API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CNPJController : ControllerBase
    {
        private readonly IRoot _rootService;
        private readonly IBrasilApi _brasilApi;

        public CNPJController(IRoot rootService, IBrasilApi brasilApi)
        {
            _rootService = rootService;
            _brasilApi = brasilApi;
        }

        [HttpGet("busca/{cnpj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCNPJ(string cnpj)
        {
            var response = await _rootService.BuscarCNPJ(cnpj);
            if (response.CodigoHttp == System.Net.HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetono);
            }
        }
    }
}
