using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sf.ContractApi.ApplicationCore.Entities;
using Sf.ContractApi.ApplicationCore.Interfaces;
using Sf.ContractApi.ApplicationCore.Services;

namespace Sf.ContractApi.WebApi.Controllers
{

    [Route("api/Contracts")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly IContractService _contractService;

        public ContractsController(IContractService contractService)
        {
            _contractService = contractService;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(Contract))]
        public async Task<IActionResult> GetContracts()
        {
            var contracts = await _contractService.ListAllContractsWithItemsAsync();
            return Ok(contracts);

        }
    }
}