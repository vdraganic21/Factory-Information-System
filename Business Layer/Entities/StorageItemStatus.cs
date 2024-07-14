using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Entities
{
    public class StorageItemStatus
    {
        public string name;
        public string id;
        public float minimalSupply;
        public List<WarehouseStatus> statuses;
    }
}
