using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Entities
{
    public class Product
    {
        public string Dokument { get; set; }
        public string Odjel { get; set; } = "255";
        public int Id { get; set; }
        public string Ime { get; set; }
        public int NosTr { get; set; } = 245; 
        public float Količina { get; set; }
        public float Zaliha { get; set; }
        public string MJ { get; set; }
        public DateTime Dostavio { get; set; }

        public Product(string dokument, int id, string ime, float količina, float zaliha, string mj, DateTime dostavio)
        {
            Dokument = dokument;
            Id = id;
            Ime = ime;
            Količina = količina;
            Zaliha = zaliha;
            MJ = mj;
            Dostavio = dostavio;
        }
    }
}
