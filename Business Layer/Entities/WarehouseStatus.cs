using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Entities
{
    public class WarehouseStatus
    {
        public string warehouseName;
        public float supply;
        public float value;
        public float reserved;
        public float leftover;

        public WarehouseStatus(string warehouseName, float supply, float value, float reserved) 
        {
            this.warehouseName = warehouseName;
            this.supply = supply;
            this.value = value;
            this.reserved = reserved;
            this.leftover = supply - reserved;
        }
    }
}
