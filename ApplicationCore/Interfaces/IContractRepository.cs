using System.Collections.Generic;
using System.Threading.Tasks;
using Sf.ContractApi.ApplicationCore.Entities;

namespace Sf.ContractApi.ApplicationCore.Interfaces
{
    public interface IContractRepository
    {
        Task<List<Contract>> ListAllWithItemsAsync();
    }
}