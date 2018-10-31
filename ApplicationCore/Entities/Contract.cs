using Sf.ContractApi.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sf.ContractApi.ApplicationCore.Entities
{
    public class Contract : BaseEntity, IAggregateRoot
    {

        public string ContractNo { get; set; }

        public DateTime ContractDate { get; set; }

        public string ContractOrganization { get; set; }

        public string ContractType { get; set; }

        public ICollection<ContractItem> ContractItems { get; set; }

    }
}
