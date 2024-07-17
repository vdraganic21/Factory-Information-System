using Business_Layer.Entities;
using System;
using System.Collections.Generic;

namespace Business_Layer.Services
{
    public class WorkOrderService
    {
        private List<WorkOrder> workOrders;

        public WorkOrderService()
        {
            workOrders = new List<WorkOrder>();

            PopulateWithSampleData();
        }

        public List<WorkOrder> GetAll()
        {
            return workOrders;
        }

        private void PopulateWithSampleData()
        {
            // Work Order 1
            WorkOrder workOrder1 = new WorkOrder
            {
                Percentage = "10%",
                RN = "RN123",
                Red = "Red1",
                NadRN = "NadRN1",
                Proizvod = "Proizvod A",
                Naziv = "Naziv 1",
                VD = "VD1",
                Prioriteta = "Visok",
                Datum = DateTime.Now.AddDays(1),
                Narucitelj = "Kupac A",
                Plan = "Plan1",
                Narudzba = "Narudzba1",
                NPoz = "NPoz1",
                PocTermin = DateTime.Now.AddDays(1),
                KraTermin = DateTime.Now.AddDays(6),
                PlanKol = "100",
                IzrKol = "80",
                VID = "VID1",
                KO = "KO1",
                Napomena = "Napomena1 123 456",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "Alt1", Poz = "Poz1", Ident = "Ident1", Opis = "Component A", Kolicina = "5", Mj = "kg", Batch = "Batch1", NormativnaOsnova = "Normativna1", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid1", PrimKlas = "PrimKlas1", SekKlas = "SekKlas1", Napomena = "Napomena1", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt2", Poz = "Poz2", Ident = "Ident2", Opis = "Component B", Kolicina = "10", Mj = "kg", Batch = "Batch2", NormativnaOsnova = "Normativna2", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid2", PrimKlas = "PrimKlas2", SekKlas = "SekKlas2", Napomena = "Napomena2", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt3", Poz = "Poz3", Ident = "Ident3", Opis = "Component C", Kolicina = "7", Mj = "kg", Batch = "Batch3", NormativnaOsnova = "Normativna3", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid3", PrimKlas = "PrimKlas3", SekKlas = "SekKlas3", Napomena = "Napomena3", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt4", Poz = "Poz4", Ident = "Ident4", Opis = "Component D", Kolicina = "12", Mj = "kg", Batch = "Batch4", NormativnaOsnova = "Normativna4", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid4", PrimKlas = "PrimKlas4", SekKlas = "SekKlas4", Napomena = "Napomena4", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt5", Poz = "Poz5", Ident = "Ident5", Opis = "Component E", Kolicina = "8", Mj = "kg", Batch = "Batch5", NormativnaOsnova = "Normativna5", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid5", PrimKlas = "PrimKlas5", SekKlas = "SekKlas5", Napomena = "Napomena5", Izdano = "Ne" }
                }
            };
            workOrders.Add(workOrder1);

            // Work Order 2
            WorkOrder workOrder2 = new WorkOrder
            {
                Percentage = "20%",
                RN = "RN456",
                Red = "Red2",
                NadRN = "NadRN2",
                Proizvod = "Proizvod B",
                Naziv = "Naziv 2",
                VD = "VD2",
                Prioriteta = "Srednji",
                Datum = DateTime.Now.AddDays(2),
                Narucitelj = "Kupac B",
                Plan = "Plan2",
                Narudzba = "Narudzba2",
                NPoz = "NPoz2",
                PocTermin = DateTime.Now.AddDays(2),
                KraTermin = DateTime.Now.AddDays(7),
                PlanKol = "120",
                IzrKol = "90",
                VID = "VID2",
                KO = "KO2",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "Alt6", Poz = "Poz6", Ident = "Ident6", Opis = "Component F", Kolicina = "6", Mj = "kg", Batch = "Batch6", NormativnaOsnova = "Normativna6", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid6", PrimKlas = "PrimKlas6", SekKlas = "SekKlas6", Napomena = "Napomena6", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt7", Poz = "Poz7", Ident = "Ident7", Opis = "Component G", Kolicina = "9", Mj = "kg", Batch = "Batch7", NormativnaOsnova = "Normativna7", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid7", PrimKlas = "PrimKlas7", SekKlas = "SekKlas7", Napomena = "Napomena7", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt8", Poz = "Poz8", Ident = "Ident8", Opis = "Component H", Kolicina = "8", Mj = "kg", Batch = "Batch8", NormativnaOsnova = "Normativna8", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid8", PrimKlas = "PrimKlas8", SekKlas = "SekKlas8", Napomena = "Napomena8", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt9", Poz = "Poz9", Ident = "Ident9", Opis = "Component I", Kolicina = "11", Mj = "kg", Batch = "Batch9", NormativnaOsnova = "Normativna9", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid9", PrimKlas = "PrimKlas9", SekKlas = "SekKlas9", Napomena = "Napomena9", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt10", Poz = "Poz10", Ident = "Ident10", Opis = "Component J", Kolicina = "7", Mj = "kg", Batch = "Batch10", NormativnaOsnova = "Normativna10", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid10", PrimKlas = "PrimKlas10", SekKlas = "SekKlas10", Napomena = "Napomena10", Izdano = "Ne" }
                }
            };
            workOrders.Add(workOrder2);

            // Work Order 3
            WorkOrder workOrder3 = new WorkOrder
            {
                Percentage = "30%",
                RN = "RN789",
                Red = "Red3",
                NadRN = "NadRN3",
                Proizvod = "Proizvod C",
                Naziv = "Naziv 3",
                VD = "VD3",
                Prioriteta = "Nizak",
                Datum = DateTime.Now.AddDays(3),
                Narucitelj = "Kupac C",
                Plan = "Plan3",
                Narudzba = "Narudzba3",
                NPoz = "NPoz3",
                PocTermin = DateTime.Now.AddDays(3),
                KraTermin = DateTime.Now.AddDays(8),
                PlanKol = "80",
                IzrKol = "60",
                VID = "VID3",
                KO = "KO3",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "Alt11", Poz = "Poz11", Ident = "Ident11", Opis = "Component K", Kolicina = "4", Mj = "kg", Batch = "Batch11", NormativnaOsnova = "Normativna11", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid11", PrimKlas = "PrimKlas11", SekKlas = "SekKlas11", Napomena = "Napomena11", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt12", Poz = "Poz12", Ident = "Ident12", Opis = "Component L", Kolicina = "8", Mj = "kg", Batch = "Batch12", NormativnaOsnova = "Normativna12", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid12", PrimKlas = "PrimKlas12", SekKlas = "SekKlas12", Napomena = "Napomena12", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt13", Poz = "Poz13", Ident = "Ident13", Opis = "Component M", Kolicina = "6", Mj = "kg", Batch = "Batch13", NormativnaOsnova = "Normativna13", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid13", PrimKlas = "PrimKlas13", SekKlas = "SekKlas13", Napomena = "Napomena13", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt14", Poz = "Poz14", Ident = "Ident14", Opis = "Component N", Kolicina = "10", Mj = "kg", Batch = "Batch14", NormativnaOsnova = "Normativna14", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid14", PrimKlas = "PrimKlas14", SekKlas = "SekKlas14", Napomena = "Napomena14", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt15", Poz = "Poz15", Ident = "Ident15", Opis = "Component O", Kolicina = "5", Mj = "kg", Batch = "Batch15", NormativnaOsnova = "Normativna15", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid15", PrimKlas = "PrimKlas15", SekKlas = "SekKlas15", Napomena = "Napomena15", Izdano = "Ne" }
                }
            };
            workOrders.Add(workOrder3);

            // Work Order 4
            WorkOrder workOrder4 = new WorkOrder
            {
                Percentage = "40%",
                RN = "RN101112",
                Red = "Red4",
                NadRN = "NadRN4",
                Proizvod = "Proizvod D",
                Naziv = "Naziv 4",
                VD = "VD4",
                Prioriteta = "Visok",
                Datum = DateTime.Now.AddDays(4),
                Narucitelj = "Kupac D",
                Plan = "Plan4",
                Narudzba = "Narudzba4",
                NPoz = "NPoz4",
                PocTermin = DateTime.Now.AddDays(4),
                KraTermin = DateTime.Now.AddDays(9),
                PlanKol = "150",
                IzrKol = "120",
                VID = "VID4",
                KO = "KO4",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "Alt16", Poz = "Poz16", Ident = "Ident16", Opis = "Component P", Kolicina = "9", Mj = "kg", Batch = "Batch16", NormativnaOsnova = "Normativna16", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid16", PrimKlas = "PrimKlas16", SekKlas = "SekKlas16", Napomena = "Napomena16", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt17", Poz = "Poz17", Ident = "Ident17", Opis = "Component Q", Kolicina = "11", Mj = "kg", Batch = "Batch17", NormativnaOsnova = "Normativna17", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid17", PrimKlas = "PrimKlas17", SekKlas = "SekKlas17", Napomena = "Napomena17", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt18", Poz = "Poz18", Ident = "Ident18", Opis = "Component R", Kolicina = "7", Mj = "kg", Batch = "Batch18", NormativnaOsnova = "Normativna18", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid18", PrimKlas = "PrimKlas18", SekKlas = "SekKlas18", Napomena = "Napomena18", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt19", Poz = "Poz19", Ident = "Ident19", Opis = "Component S", Kolicina = "13", Mj = "kg", Batch = "Batch19", NormativnaOsnova = "Normativna19", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid19", PrimKlas = "PrimKlas19", SekKlas = "SekKlas19", Napomena = "Napomena19", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt20", Poz = "Poz20", Ident = "Ident20", Opis = "Component T", Kolicina = "6", Mj = "kg", Batch = "Batch20", NormativnaOsnova = "Normativna20", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid20", PrimKlas = "PrimKlas20", SekKlas = "SekKlas20", Napomena = "Napomena20", Izdano = "Ne" }
                }
            };
            workOrders.Add(workOrder4);

            // Work Order 5
            WorkOrder workOrder5 = new WorkOrder
            {
                Percentage = "50%",
                RN = "RN131415",
                Red = "Red5",
                NadRN = "NadRN5",
                Proizvod = "Proizvod E",
                Naziv = "Naziv 5",
                VD = "VD5",
                Prioriteta = "Srednji",
                Datum = DateTime.Now.AddDays(5),
                Narucitelj = "Kupac E",
                Plan = "Plan5",
                Narudzba = "Narudzba5",
                NPoz = "NPoz5",
                PocTermin = DateTime.Now.AddDays(5),
                KraTermin = DateTime.Now.AddDays(10),
                PlanKol = "200",
                IzrKol = "150",
                VID = "VID5",
                KO = "KO5",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "Alt21", Poz = "Poz21", Ident = "Ident21", Opis = "Component U", Kolicina = "8", Mj = "kg", Batch = "Batch21", NormativnaOsnova = "Normativna21", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid21", PrimKlas = "PrimKlas21", SekKlas = "SekKlas21", Napomena = "Napomena21", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt22", Poz = "Poz22", Ident = "Ident22", Opis = "Component V", Kolicina = "12", Mj = "kg", Batch = "Batch22", NormativnaOsnova = "Normativna22", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid22", PrimKlas = "PrimKlas22", SekKlas = "SekKlas22", Napomena = "Napomena22", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt23", Poz = "Poz23", Ident = "Ident23", Opis = "Component W", Kolicina = "9", Mj = "kg", Batch = "Batch23", NormativnaOsnova = "Normativna23", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid23", PrimKlas = "PrimKlas23", SekKlas = "SekKlas23", Napomena = "Napomena23", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt24", Poz = "Poz24", Ident = "Ident24", Opis = "Component X", Kolicina = "14", Mj = "kg", Batch = "Batch24", NormativnaOsnova = "Normativna24", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid24", PrimKlas = "PrimKlas24", SekKlas = "SekKlas24", Napomena = "Napomena24", Izdano = "Ne" },
                    new ComponentListItem { Alt = "Alt25", Poz = "Poz25", Ident = "Ident25", Opis = "Component Y", Kolicina = "7", Mj = "kg", Batch = "Batch25", NormativnaOsnova = "Normativna25", Aktivno = "Da", Zavrseno = "Da", Vid = "Vid25", PrimKlas = "PrimKlas25", SekKlas = "SekKlas25", Napomena = "Napomena25", Izdano = "Ne" }
                }
            };
            workOrders.Add(workOrder5);
        }
    }
}
