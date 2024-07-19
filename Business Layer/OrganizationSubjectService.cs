using Business_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class OrganizationSubjectService
    {
        private List<OrganizationSubject> organizationSubjects = new List<OrganizationSubject>();

        public OrganizationSubjectService()
        {
            organizationSubjects.Add(new OrganizationSubject("200", "Odjel zavarene konstrukcije"));
            organizationSubjects.Add(new OrganizationSubject("250", "Glavno skladište"));
            organizationSubjects.Add(new OrganizationSubject("300", "Metal Transport d.o.o."));
        }

        public List<OrganizationSubject> GetAll()
        {
            return organizationSubjects;
        }
    }
}
