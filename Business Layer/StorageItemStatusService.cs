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
                    name = "Žica za zavarivanje SGEZ3 1,2",
                    id = "52-120-005274",
                    minimalSupply = 100,
                    valuePerUnit = 25,
                    measuringUnit = "m",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 50, 1000, 7),
                        new WarehouseStatus("Međuskladište 1", 121, 2420, 0)
                    }
                },
                new StorageItemStatus
                {
                    name = "Čelična cijev bešavna 3/4'",
                    id = "58-121-050247",
                    minimalSupply = 25,
                    valuePerUnit = 50,
                    measuringUnit = "m",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 25, 10000, 0),
                        new WarehouseStatus("Međuskladište 2", 300, 15000, 0)
                    }
                },
                new StorageItemStatus
                {
                    name = "Prašak za zavarivanje AR18.5",
                    id = "11-576-000047",
                    minimalSupply = 20,
                    valuePerUnit = 30,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 33, 990, 5),
                        new WarehouseStatus("Međuskladište 1", 2, 60, 10)
                    }
                },
                new StorageItemStatus
                {
                    name = "Čelična ploča 2000x1000x10",
                    id = "34-222-001011",
                    minimalSupply = 10,
                    valuePerUnit = 150,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 15, 2250, 0),
                        new WarehouseStatus("Međuskladište 2", 5, 750, 2)
                    }
                },
                new StorageItemStatus
                {
                    name = "Aluminijska šipka 50x50x3000",
                    id = "22-320-002345",
                    minimalSupply = 20,
                    valuePerUnit = 200,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 25, 5000, 0),
                        new WarehouseStatus("Međuskladište 1", 10, 2000, 1)
                    }
                },
                new StorageItemStatus
                {
                    name = "Ventil kuglasti DN50 PN16",
                    id = "45-678-009876",
                    minimalSupply = 15,
                    valuePerUnit = 75,
                    measuringUnit = "kom",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 20, 1500, 3),
                        new WarehouseStatus("Međuskladište 3", 5, 375, 1)
                    }
                },
                new StorageItemStatus
                {
                    name = "Čelična cijev 100x4",
                    id = "58-123-030250",
                    minimalSupply = 50,
                    valuePerUnit = 60,
                    measuringUnit = "m",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 100, 6000, 5),
                        new WarehouseStatus("Međuskladište 1", 50, 3000, 10)
                    }
                },
                new StorageItemStatus
                {
                    name = "Bakrena ploča 1000x2000x2",
                    id = "78-999-000123",
                    minimalSupply = 5,
                    valuePerUnit = 500,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 8, 4000, 1),
                        new WarehouseStatus("Međuskladište 2", 4, 2000, 2)
                    }
                },
                new StorageItemStatus
                {
                    name = "Inox šipka 20x20x3000",
                    id = "91-110-005789",
                    minimalSupply = 30,
                    valuePerUnit = 100,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 40, 4000, 5),
                        new WarehouseStatus("Međuskladište 3", 10, 1000, 0)
                    }
                },
                new StorageItemStatus
                {
                    name = "Mesing cijev 10x1",
                    id = "65-432-005432",
                    minimalSupply = 80,
                    valuePerUnit = 120,
                    measuringUnit = "m",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 100, 12000, 10),
                        new WarehouseStatus("Međuskladište 1", 30, 3600, 5)
                    }
                },
                new StorageItemStatus
                {
                    name = "Olovna ploča 1000x500x5",
                    id = "33-789-004567",
                    minimalSupply = 10,
                    valuePerUnit = 600,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 12, 7200, 2),
                        new WarehouseStatus("Međuskladište 2", 6, 3600, 1)
                    }
                },
                new StorageItemStatus
                {
                    name = "Ventil sigurnosni DN20",
                    id = "88-222-009874",
                    minimalSupply = 25,
                    valuePerUnit = 40,
                    measuringUnit = "kom",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 30, 1200, 0),
                        new WarehouseStatus("Međuskladište 3", 15, 600, 1)
                    }
                },
                new StorageItemStatus
                {
                    name = "Čelična cijev 150x5",
                    id = "58-125-031250",
                    minimalSupply = 60,
                    valuePerUnit = 70,
                    measuringUnit = "m",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 120, 8400, 8),
                        new WarehouseStatus("Međuskladište 1", 60, 4200, 15)
                    }
                },
                new StorageItemStatus
                {
                    name = "Aluminijska ploča 1500x3000x10",
                    id = "22-324-002349",
                    minimalSupply = 12,
                    valuePerUnit = 250,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 18, 4500, 3),
                        new WarehouseStatus("Međuskladište 2", 9, 2250, 2)
                    }
                },
                new StorageItemStatus
                {
                    name = "Inox cijev 50x1.5",
                    id = "91-115-005789",
                    minimalSupply = 40,
                    valuePerUnit = 90,
                    measuringUnit = "m",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 60, 5400, 6),
                        new WarehouseStatus("Međuskladište 3", 20, 1800, 2)
                    }
                },
                new StorageItemStatus
                {
                    name = "Mesing šipka 30x30x3000",
                    id = "65-438-005435",
                    minimalSupply = 25,
                    valuePerUnit = 110,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 35, 3850, 0),
                        new WarehouseStatus("Međuskladište 1", 15, 1650, 3)
                    }
                },
                new StorageItemStatus
                {
                    name = "Olovna cijev 20x1",
                    id = "33-791-004569",
                    minimalSupply = 15,
                    valuePerUnit = 130,
                    measuringUnit = "m",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 20, 2600, 1),
                        new WarehouseStatus("Međuskladište 2", 10, 1300, 1)
                    }
                },
                new StorageItemStatus
                {
                    name = "Bakrena šipka 10x10x3000",
                    id = "78-999-000126",
                    minimalSupply = 30,
                    valuePerUnit = 300,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 45, 13500, 2),
                        new WarehouseStatus("Međuskladište 1", 15, 4500, 0)
                    }
                },
                new StorageItemStatus
                {
                    name = "Inox ploča 2000x1000x5",
                    id = "91-119-005792",
                    minimalSupply = 10,
                    valuePerUnit = 350,
                    measuringUnit = "kg",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 15, 5250, 1),
                        new WarehouseStatus("Međuskladište 3", 5, 1750, 1)
                    }
                },
                new StorageItemStatus
                {
                    name = "Ventil kuglasti DN100 PN16",
                    id = "45-679-009879",
                    minimalSupply = 5,
                    valuePerUnit = 500,
                    measuringUnit = "kom",
                    statuses = new List<WarehouseStatus>
                    {
                        new WarehouseStatus("Glavno skladište", 10, 5000, 2),
                        new WarehouseStatus("Međuskladište 3", 3, 1500, 1)
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
