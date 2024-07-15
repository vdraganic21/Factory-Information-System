using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Entities
{
    public class WorkOrder
    {
        public string Percentage { get; set; }
        public string RN { get; set; }
        public string Red { get; set; }
        public string NadRN { get; set; }
        public string Proizvod { get; set; }
        public string Naziv { get; set; }
        public string VD { get; set; }
        public string Prioriteta { get; set; }
        public DateTime Datum { get; set; }
        public string Narucitelj { get; set; }
        public string Plan { get; set; }
        public string Narudzba { get; set; }
        public string NPoz { get; set; }
        public DateTime PocTermin { get; set; }
        public DateTime KraTermin { get; set; }
        public string PlanKol { get; set; }
        public string IzrKol { get; set; }
        public string VID { get; set; }
        public string KO { get; set; }

        public List<ComponentListItem> ComponentListItems { get; set; }

        public WorkOrder()
        {
            ComponentListItems = new List<ComponentListItem>();
        }
    }
}
