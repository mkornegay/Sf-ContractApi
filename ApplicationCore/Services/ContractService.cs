using Sf.ContractApi.ApplicationCore.Entities;
using Sf.ContractApi.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sf.ContractApi.ApplicationCore.Services
{
    public class ContractService : IContractService
    {
        private readonly IAsyncRepository<Contract> _contractRepository;

        public ContractService(IAsyncRepository<Contract> contractAsyncRepository)
        {
            _contractRepository = contractAsyncRepository;
        }

        public async Task<List<Contract>> ListAllContractsWithItemsAsync()
        {
            var contracts = await _contractRepository.ListAllAsync();

            return contracts;
            
        }
    }
}
