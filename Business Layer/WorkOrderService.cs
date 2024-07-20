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
                RN = "42-G61-000448",
                Red = "0",
                NadRN = "42-G61-000449",
                Proizvod = "S-04-18-5098-21",
                Naziv = "2E ZL 5000 PRSTEN DISKA N1,5 553JS3+N (K-50-21-053203)",
                VD = "RG1",
                Prioriteta = "5 - Normalan prioritet",
                Datum = DateTime.Now.AddDays(-1),
                Narucitelj = "550",
                Plan = "24-M0H-0001",
                Narudzba = "24-190-000379",
                NPoz = "1",
                PocTermin = DateTime.Now.AddDays(1),
                KraTermin = DateTime.Now.AddDays(6),
                PlanKol = "10",
                IzrKol = "0",
                VID = "500",
                KO = "KO1",
                Napomena = "Provesti testiranje funkcionalnosti i zapisnik o kontroli.",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "0", Poz = "187", Ident = "13-C76-000978", Opis = "B7-32 5200 Brtvenica gR3", Kolicina = "5", Mj = "kom", Batch = "1", NormativnaOsnova = "0", Aktivno = "Da", Zavrseno = "Ne", Vid = "340", PrimKlas = "1A", SekKlas = "3D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "2", Poz = "189", Ident = "15-C78-000980", Opis = "B7-34 5400 Brtvenica gR5", Kolicina = "15", Mj = "kom", Batch = "3", NormativnaOsnova = "2", Aktivno = "Da", Zavrseno = "Ne", Vid = "342", PrimKlas = "1C", SekKlas = "5D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "5", Poz = "192", Ident = "18-C81-000983", Opis = "B7-37 5700 Brtvenica gR8", Kolicina = "30", Mj = "kom", Batch = "6", NormativnaOsnova = "5", Aktivno = "Da", Zavrseno = "Ne", Vid = "345", PrimKlas = "1F", SekKlas = "8D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "4", Poz = "191", Ident = "17-C80-000982", Opis = "B7-36 5600 Brtvenica gR7", Kolicina = "25", Mj = "kom", Batch = "5", NormativnaOsnova = "4", Aktivno = "Da", Zavrseno = "Ne", Vid = "344", PrimKlas = "1E", SekKlas = "7D", Napomena = "", Izdano = "0%" },
                }
            };
            workOrders.Add(workOrder1);

            // Work Order 2
            WorkOrder workOrder2 = new WorkOrder
            {
                Percentage = "20%",
                RN = "51-G61-000449",
                Red = "1",
                NadRN = "42-G61-000450",
                Proizvod = "S-04-18-5099-21",
                Naziv = "4E ZL 7500 DVODIJELNI PRSTEN N2 654JS4+N (K-51-21-054304)",
                VD = "RG2",
                Prioriteta = "4 - Visoki prioritet",
                Datum = DateTime.Now.AddDays(-2),
                Narucitelj = "551",
                Plan = "24-M0H-0002",
                Narudzba = "34-190-000380",
                NPoz = "2",
                PocTermin = DateTime.Now.AddDays(2),
                KraTermin = DateTime.Now.AddDays(10),
                PlanKol = "20",
                IzrKol = "0",
                VID = "501",
                KO = "KO2",
                Napomena = "Izvršiti detaljno ispitivanje i izvještaj o greškama.",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "1", Poz = "188", Ident = "14-C77-000979", Opis = "B7-33 5300 Brtvenica gR4", Kolicina = "10", Mj = "kom", Batch = "2", NormativnaOsnova = "1", Aktivno = "Da", Zavrseno = "Ne", Vid = "341", PrimKlas = "1B", SekKlas = "4D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "2", Poz = "189", Ident = "15-C78-000980", Opis = "B7-34 5400 Brtvenica gR5", Kolicina = "15", Mj = "kom", Batch = "3", NormativnaOsnova = "2", Aktivno = "Da", Zavrseno = "Ne", Vid = "342", PrimKlas = "1C", SekKlas = "5D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "0", Poz = "187", Ident = "13-C76-000978", Opis = "B7-32 5200 Brtvenica gR3", Kolicina = "5", Mj = "kom", Batch = "1", NormativnaOsnova = "0", Aktivno = "Da", Zavrseno = "Ne", Vid = "340", PrimKlas = "1A", SekKlas = "3D", Napomena = "", Izdano = "0%" },
                }
            };
            workOrders.Add(workOrder2);

            // Work Order 3
            WorkOrder workOrder3 = new WorkOrder
            {
                Percentage = "50%",
                RN = "55-G61-000450",
                Red = "2",
                NadRN = "42-G61-000451",
                Proizvod = "S-04-18-5100-21",
                Naziv = "6E ZL 10000 ŠIPKA NAVOJNA N3 755JS5+N (K-52-21-055405)",
                VD = "RG3",
                Prioriteta = "3 - Hitno",
                Datum = DateTime.Now.AddDays(-3),
                Narucitelj = "552",
                Plan = "24-M0H-0003",
                Narudzba = "25-190-000381",
                NPoz = "3",
                PocTermin = DateTime.Now.AddDays(3),
                KraTermin = DateTime.Now.AddDays(15),
                PlanKol = "30",
                IzrKol = "0",
                VID = "502",
                KO = "KO3",
                Napomena = "",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "2", Poz = "189", Ident = "15-C78-000980", Opis = "B7-34 5400 Brtvenica gR5", Kolicina = "15", Mj = "kom", Batch = "3", NormativnaOsnova = "2", Aktivno = "Da", Zavrseno = "Ne", Vid = "342", PrimKlas = "1C", SekKlas = "5D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "5", Poz = "192", Ident = "18-C81-000983", Opis = "B7-37 5700 Brtvenica gR8", Kolicina = "30", Mj = "kom", Batch = "6", NormativnaOsnova = "5", Aktivno = "Da", Zavrseno = "Ne", Vid = "345", PrimKlas = "1F", SekKlas = "8D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "4", Poz = "191", Ident = "17-C80-000982", Opis = "B7-36 5600 Brtvenica gR7", Kolicina = "25", Mj = "kom", Batch = "5", NormativnaOsnova = "4", Aktivno = "Da", Zavrseno = "Ne", Vid = "344", PrimKlas = "1E", SekKlas = "7D", Napomena = "", Izdano = "0%" },
                }
            };
            workOrders.Add(workOrder3);

            // Work Order 4
            WorkOrder workOrder4 = new WorkOrder
            {
                Percentage = "30%",
                RN = "22-G61-000451",
                Red = "3",
                NadRN = "42-G61-000452",
                Proizvod = "S-04-18-5101-21",
                Naziv = "8E ZL 12000 PRSTEN DISKA N4 855JS6+N (K-53-21-056506)",
                VD = "RG4",
                Prioriteta = "2 - Vrlo visok prioritet",
                Datum = DateTime.Now.AddDays(-4),
                Narucitelj = "553",
                Plan = "24-M0H-0004",
                Narudzba = "14-190-000382",
                NPoz = "4",
                PocTermin = DateTime.Now.AddDays(4),
                KraTermin = DateTime.Now.AddDays(20),
                PlanKol = "40",
                IzrKol = "0",
                VID = "503",
                KO = "KO4",
                Napomena = "",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "3", Poz = "190", Ident = "16-C79-000981", Opis = "B7-35 5500 Brtvenica gR6", Kolicina = "20", Mj = "kom", Batch = "4", NormativnaOsnova = "3", Aktivno = "Da", Zavrseno = "Ne", Vid = "343", PrimKlas = "1D", SekKlas = "6D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "1", Poz = "188", Ident = "14-C77-000979", Opis = "B7-33 5300 Brtvenica gR4", Kolicina = "10", Mj = "kom", Batch = "2", NormativnaOsnova = "1", Aktivno = "Da", Zavrseno = "Ne", Vid = "341", PrimKlas = "1B", SekKlas = "4D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "2", Poz = "189", Ident = "15-C78-000980", Opis = "B7-34 5400 Brtvenica gR5", Kolicina = "15", Mj = "kom", Batch = "3", NormativnaOsnova = "2", Aktivno = "Da", Zavrseno = "Ne", Vid = "342", PrimKlas = "1C", SekKlas = "5D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "0", Poz = "187", Ident = "13-C76-000978", Opis = "B7-32 5200 Brtvenica gR3", Kolicina = "5", Mj = "kom", Batch = "1", NormativnaOsnova = "0", Aktivno = "Da", Zavrseno = "Da", Vid = "340", PrimKlas = "1A", SekKlas = "3D", Napomena = "", Izdano = "100%" },
                }
            };
            workOrders.Add(workOrder4);

            // Work Order 5
            WorkOrder workOrder5 = new WorkOrder
            {
                Percentage = "60%",
                RN = "48-G61-000452",
                Red = "4",
                NadRN = "42-G61-000453",
                Proizvod = "S-04-18-5102-21",
                Naziv = "10E ZL 15000 BRTVENICE N5 955JS7+N (K-54-21-057607)",
                VD = "RG5",
                Prioriteta = "1 - Hitno",
                Datum = DateTime.Now.AddDays(-5),
                Narucitelj = "554",
                Plan = "24-M0H-0005",
                Narudzba = "66-190-000383",
                NPoz = "5",
                PocTermin = DateTime.Now.AddDays(5),
                KraTermin = DateTime.Now.AddDays(25),
                PlanKol = "50",
                IzrKol = "0",
                VID = "504",
                KO = "KO5",
                Napomena = "",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "4", Poz = "191", Ident = "17-C80-000982", Opis = "B7-36 5600 Brtvenica gR7", Kolicina = "25", Mj = "kom", Batch = "5", NormativnaOsnova = "4", Aktivno = "Da", Zavrseno = "Ne", Vid = "344", PrimKlas = "1E", SekKlas = "7D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "5", Poz = "192", Ident = "18-C81-000983", Opis = "B7-37 5700 Brtvenica gR8", Kolicina = "30", Mj = "kom", Batch = "6", NormativnaOsnova = "5", Aktivno = "Da", Zavrseno = "Ne", Vid = "345", PrimKlas = "1F", SekKlas = "8D", Napomena = "", Izdano = "0%" },
                }
            };
            workOrders.Add(workOrder5);

            // Work Order 6
            WorkOrder workOrder6 = new WorkOrder
            {
                Percentage = "80%",
                RN = "57-G61-000453",
                Red = "5",
                NadRN = "42-G61-000454",
                Proizvod = "S-04-18-5103-21",
                Naziv = "12E ZL 20000 PRSTEN DISKA N6 1055JS8+N (K-55-21-058708)",
                VD = "RG6",
                Prioriteta = "6 - Kritičan prioritet",
                Datum = DateTime.Now.AddDays(-6),
                Narucitelj = "555",
                Plan = "24-M0H-0006",
                Narudzba = "77-190-000384",
                NPoz = "6",
                PocTermin = DateTime.Now.AddDays(6),
                KraTermin = DateTime.Now.AddDays(30),
                PlanKol = "60",
                IzrKol = "0",
                VID = "505",
                KO = "KO6",
                Napomena = "Obavezno ispitivanje svih karakteristika i izrada izvještaja o kvaliteti.",
                ComponentListItems = new List<ComponentListItem>
                {
                    new ComponentListItem { Alt = "5", Poz = "192", Ident = "18-C81-000983", Opis = "B7-37 5700 Brtvenica gR8", Kolicina = "30", Mj = "kom", Batch = "6", NormativnaOsnova = "5", Aktivno = "Da", Zavrseno = "Ne", Vid = "345", PrimKlas = "1F", SekKlas = "8D", Napomena = "", Izdano = "0%" },
                    new ComponentListItem { Alt = "4", Poz = "191", Ident = "17-C80-000982", Opis = "B7-36 5600 Brtvenica gR7", Kolicina = "25", Mj = "kom", Batch = "5", NormativnaOsnova = "4", Aktivno = "Da", Zavrseno = "Ne", Vid = "344", PrimKlas = "1E", SekKlas = "7D", Napomena = "", Izdano = "0%" },
                }
            };
            workOrders.Add(workOrder6);
        }
    }
}
