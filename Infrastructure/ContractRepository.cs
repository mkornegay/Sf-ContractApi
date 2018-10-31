using Microsoft.EntityFrameworkCore;
using Sf.ContractApi.ApplicationCore.Entities;
using Sf.ContractApi.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sf.ContractApi.Infrastructure
{
    public class ContractRepository : EfRepository<Contract>, IContractRepository
    {
        public ContractRepository(ContractContext contractContext)
            : base(contractContext)
        { }

        public Task<List<Contract>> ListAllWithItemsAsync()
        {
            return _contractContext.Contracts
                .Include(ci => ci.ContractItems)
                    .ThenInclude(i => i.Item)
                .ToListAsync();
        }
    }
}
