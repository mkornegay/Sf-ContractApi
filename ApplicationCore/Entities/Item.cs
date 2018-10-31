using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sf.ContractApi.ApplicationCore.Entities
{
    public class Item : BaseEntity
    {
   
        public string Sku { get; set; }

        public string Description { get; set; }

        public decimal ListCost { get; set; }

        [JsonIgnore]
        public ICollection<ContractItem> ContractItems { get; set; }
    }
}
