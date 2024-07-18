using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer.Entities;

namespace Business_Layer
{
    public class StorageItemStatusService
    {
        private List<StorageItemStatus> storageItemStatuses;

        public StorageItemStatusService()
        {
            storageItemStatuses = new List<StorageItemStatus>
            {
                new StorageItemStatus
                {
                    name = "Item1",
                    id = "001",
                    minimalSupply = 0,
                    valuePerUnit = 50,
                    measuringUnit = "kom.",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Warehouse A", 100, 5000, 20),
                        new WarehouseStatus("Warehouse B", 150, 7500, 30)
                    }
                },
                new StorageItemStatus
                {
                    name = "Item2",
                    id = "002",
                    minimalSupply = 1,
                    valuePerUnit = 50,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Warehouse A", 200, 10000, 50),
                        new WarehouseStatus("Warehouse C", 300, 15000, 70)
                    }
                },
                new StorageItemStatus
                {
                    name = "Item3",
                    id = "003",
                    minimalSupply = 2,
                    valuePerUnit = 50,
                    measuringUnit = "kom.",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Warehouse A", 20, 100, 5),
                        new WarehouseStatus("Warehouse B", 400, 2000, 10)
                    }
                }
            };
        }

        public List<StorageItemStatus> GetAll()
        {
            return storageItemStatuses;
        }

        public List<string> GetAllNames()
        {
            return storageItemStatuses.Select(item => item.name).ToList();
        }

        public List<string> GetAllIds()
        {
            return storageItemStatuses.Select(item => item.id).ToList();
        }

        public StorageItemStatus GetStorageItemStatusByName(string name)
        {
            return storageItemStatuses.FirstOrDefault(item => item.name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public StorageItemStatus GetStorageItemStatusById(string id)
        {
            return storageItemStatuses.FirstOrDefault(item => item.id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }
    }
}
