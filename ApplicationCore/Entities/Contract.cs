using Sf.ContractApi.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sf.ContractApi.ApplicationCore.Entities
{
    public class Contract : BaseEntity, IAggregateRoot
    {
        private readonly List<ContractItem> _contractItems = new List<ContractItem>();

        public string ContractNo { get; set; }
        public DateTime ContractDate { get; set; }
        public string ContractOrganization { get; set; }
        public string ContractType { get; set; }
        public IReadOnlyCollection<ContractItem> ContractItems => _contractItems.AsReadOnly();

        //public void AddItem(int itemId)
        //{
        //    if (!ContractItems.Any(i => i.ItemId == itemId))
        //    {
        //        _contractItems.Add(new ContractItem
        //        {
        //            ContractId = Id,
        //            ItemId = itemId
        //        });
        //        return;
        //    }
        //    var existingItem = ContractItems.FirstOrDefault(i => i.ItemId == itemId);
            
        //}


    }
}
