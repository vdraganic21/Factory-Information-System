using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class DocumentTypeService
    {
        private List<String> documentTypes = new List<String>();

        public DocumentTypeService()
        {
            documentTypes.Add("D57 - Radni nalog");
        }
        public List<String> GetAll()
        {
            return documentTypes; 
        }
    }
}
