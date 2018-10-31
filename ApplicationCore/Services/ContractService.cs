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
        private readonly IContractRepository _contractRepository;
        //private readonly IAsyncRepository<ContractItem> _contractItemRepository;
        //private readonly IAsyncRepository<Item> _itemRepository;

        public ContractService(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;

        }

        public async Task<List<Contract>> ListAllContractsWithItemsAsync()
        {
            var contracts = await _contractRepository.ListAllWithItemsAsync();

            return contracts;
            
        }

   
    }
}
