using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Entities
{
    public class StorageItemStatus
    {
        public string name {  get; set; }
        public string id { get; set; }
        public float minimalSupply { get; set; }
        public float valuePerUnit { get; set; }
        public string measuringUnit { get; set; }
        public List<WarehouseStatus> statuses { get; set; }

        public float TotalSupply => statuses?.Sum(s => s.supply) ?? 0;
        public float TotalValue => statuses?.Sum(s => s.value) ?? 0;
        public float TotalReserved => statuses?.Sum(s => s.reserved) ?? 0;
        public float TotalLeftover => statuses?.Sum(s => s.leftover) ?? 0;
    }
}
