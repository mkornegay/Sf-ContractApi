using System;
using System.Collections.Generic;
using System.Text;

namespace Sf.ContractApi.ApplicationCore.Entities
{
    public class ContractItem : BaseEntity
    {
        public int ItemId { get; set; }
        public int ContractId { get; set; }
    }
}
