using Business_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>
            {
                new Product("D8A9B4", "P42T9Q", "Čelična cijev 50mm x 2m", 0.0f, 100.0f, "m", RandomDate()),
                new Product("D4C8E7", "P53J2R", "Aluminijska ploča 1000x2000x5", 0.0f, 30.0f, "kg", RandomDate()),
                new Product("A7F6D3", "P74L1T", "Bakreni kabel 1.5mm", 0.0f, 150.0f, "kg", RandomDate()),
                new Product("B5E9C2", "P85N3W", "Mesingasti ventil DN25", 0.0f, 25.0f, "kom", RandomDate()),
                new Product("C4A1B6", "P92M8X", "Nehrđajući čelik šipka 20mm x 3m", 0.0f, 50.0f, "m", RandomDate()),
                new Product("E7B2F9", "P33K5Y", "Karbon čelična ploča 2000x1000x10", 0.0f, 60.0f, "kg", RandomDate()),
                new Product("F6D1A3", "P21Z4V", "Nikal cijev 30mm x 1m", 0.0f, 70.0f, "m", RandomDate()),
                new Product("G9C4E8", "P97X2R", "Titanski lim 500x500x2", 0.0f, 80.0f, "kg", RandomDate()),
                new Product("H3B7D2", "P64J8N", "Inconel žica 2mm", 0.0f, 120.0f, "kg", RandomDate()),
                new Product("J8A5E6", "P12Q3M", "Aluminijska ekstruzija 50x50x2000", 0.0f, 40.0f, "m", RandomDate()),
                new Product("K2B9D7", "P73T6F", "Brončani zupčanik 100mm", 0.0f, 150.0f, "kom", RandomDate()),
                new Product("L6C3F1", "P84M7R", "Cinkovni lim 1000x1000x3", 0.0f, 25.0f, "kg", RandomDate()),
                new Product("M1D8A9", "P65J4K", "Mjedena cijev 25mm x 2m", 0.0f, 55.0f, "m", RandomDate()),
                new Product("N7E2B4", "P98L1M", "Aluminijski okvir 40x40x3000", 0.0f, 45.0f, "m", RandomDate()),
                new Product("O4A9C5", "P21Q8T", "Karbon čelična šipka 10mm x 1m", 0.0f, 35.0f, "m", RandomDate()),
                new Product("P3D7E1", "P56J9V", "Nehrđajući čelik lim 3000x1500x5", 0.0f, 90.0f, "kg", RandomDate()),
                new Product("Q5C8F2", "P79K3W", "Mesingasti čep 20mm", 0.0f, 50.0f, "kom", RandomDate()),
                new Product("R2A4D6", "P91M7X", "Titanski okvir 500x1000x2", 0.0f, 75.0f, "kg", RandomDate()),
                new Product("S6E9B3", "P23J5N", "Inconel ploča 1000x1000x1", 0.0f, 60.0f, "kg", RandomDate()),
                new Product("T3B7C1", "P85Q2T", "Aluminijska cijev 20mm x 1m", 0.0f, 35.0f, "m", RandomDate()),
                new Product("U4D8E9", "P94L3M", "Brončana ploča 500x500x10", 0.0f, 40.0f, "kg", RandomDate())
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }

        private static DateTime RandomDate()
        {
            var random = new Random();
            var days = random.Next(-10, 1);
            return DateTime.Now.AddDays(days);
        }
    }
}
