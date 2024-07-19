using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class DocumentTypeService
    {
        private List<string> documentTypes = new List<string>();

        public DocumentTypeService()
        {
            documentTypes.AddRange(new List<string>
            {
                "E7P - Aktivni dinamički plan",
                "A4X - Arhivski plan",
                "D57 - Dostavnica",
                "L2R - Interna narudžba",
                "T3Y - Međuskladišnica",
                "N8Q - Nalog za izradu predkalkulacije",
                "V1B - Nalog za otpremu",
                "H6J - Nalog za otpremu na doradu",
                "Q7F - Nalog za proizvodnju",
                "P5M - Narudžba kupca",
                "D4G - Plan proizvodnje",
                "S9N - Plan proizvodnje armatura",
                "M2T - Plan proizvodnje fazona",
                "J8H - Plan proizvodnje izrada jezgri",
                "C5L - Plan proizvodnje odljevka",
                "F7Q - Plan proizvodnje osalo",
                "K1Z - Plan proizvodnje poluproizvoda",
                "G6X - Ponuda kupca",
                "R3C - Predatnica strojne obrade",
                "W2B - Primka skladišta gotovih proizvoda",
                "T9P - Primka skladišta obojenih metala",
                "U1K - Primka skladišta poluproizvoda",
                "L8Q - Primka skladišta sirovina",
                "Y7C - Primka skladišta uzoraka",
                "R1M - Primka tuđe robe",
                "057 - Radni nalog",
                "F2J - Reklamacija kupca",
                "C6L - Trebovanje",
                "W8X - Trebovanje dijelova i sklopova",
                "B3P - Trebovanje po radnom nalogu",
                "A1K - Trebovanje robe po reklamaciji",
                "M7D - Trebovanje robe za popravak",
                "Z4T - Trebovanje tuđe robe po radnom nalogu",
                "L5N - Trebovanje za održavanje",
                "J2H - Viškovi u inventuri",
                "P9C - Viškovi u inventuri pogona ljevaonica",
                "E3M - Web narudžba"
            });
        }

        public List<string> GetAll()
        {
            return documentTypes;
        }
    }
}
