using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Entities
{
    public class OrganizationSubject
    {
        public string Id;
        public string Name;

        public OrganizationSubject(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
