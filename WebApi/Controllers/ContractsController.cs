using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sf.ContractApi.ApplicationCore.Configuration;
using Sf.ContractApi.ApplicationCore.Entities;
using Sf.ContractApi.ApplicationCore.Interfaces;
using Sf.ContractApi.ApplicationCore.Logging;
using Sf.ContractApi.ApplicationCore.Services;

namespace Sf.ContractApi.WebApi.Controllers
{

    [ApiController]
    public class ContractsController : ControllerBase
    {
        private readonly IContractService _contractService;
        private readonly IOptions<ApplicationConfiguration> _config;
        private readonly ILogger<ContractsController> _logger;

        public ContractsController(IOptions<ApplicationConfiguration> config,
            IContractService contractService,
            ILogger<ContractsController> logger)
        {
            _config = config;
            _contractService = contractService;
            _logger = logger;
        }

        [HttpGet]
        [Route("Contracts/GetContracts")]
        [ProducesResponseType(200, Type = typeof(Contract))]
        public async Task<IActionResult> GetContracts()
        {
            _logger.LogInformation(LoggingEvents.ListItems, "Getting contract items.");
            var contracts = await _contractService.ListAllContractsWithItemsAsync();

            if (contracts == null)
            {
                _logger.LogWarning(LoggingEvents.NoItemsInList, "Could not find any contract items to list.");
                return NotFound();
            }

            return Ok(contracts);

        }

        [HttpGet]
        [Route("Contracts/CheckConfig")]
        [ProducesResponseType(200)]
        public IActionResult CheckConfig()
        {
            var setting1 = $"the settings are {_config.Value.Setting1} and the subsection first option is {_config.Value.SubsectionA.Option1}";
            return Ok(setting1);
        }

        [HttpGet]
        [Route("Contracts/SampleFailedRequest")]
        public IActionResult SampleFailedRequest()
        {
            var message = "Sample failed request";

            try
            {
                _logger.LogInformation("About to throw an exception to App Insights");
                throw new Exception(message);
            }
            catch (Exception ex)
            {
                _logger.LogError(message, ex);
                return BadRequest(ex);

            }


        }
    }
}