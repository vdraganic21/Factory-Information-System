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
            organizationSubjects.Add(new OrganizationSubject("310", "Odjel za održavanje"));
            organizationSubjects.Add(new OrganizationSubject("320", "Odjel za kvalitetu"));
            organizationSubjects.Add(new OrganizationSubject("330", "Odjel za nabavu"));
            organizationSubjects.Add(new OrganizationSubject("3401", "Ljevaonica"));
            organizationSubjects.Add(new OrganizationSubject("3402", "Talionica"));
            organizationSubjects.Add(new OrganizationSubject("360", "Odjel za istraživanje i razvoj"));
            organizationSubjects.Add(new OrganizationSubject("370", "Servis i popravak"));
            organizationSubjects.Add(new OrganizationSubject("40057", "Metal Design d.o.o."));
            organizationSubjects.Add(new OrganizationSubject("41023", "AluKonstrukcija d.o.o."));
            organizationSubjects.Add(new OrganizationSubject("42021", "Messer Croatia"));
            organizationSubjects.Add(new OrganizationSubject("43099", "Strojar Bistra d.o.o."));
            organizationSubjects.Add(new OrganizationSubject("44022", "Gumimpex Varaždin d.d."));
            organizationSubjects.Add(new OrganizationSubject("45011", "Metal Logistics Ltd."));
            organizationSubjects.Add(new OrganizationSubject("46033", "Hawle Austrija"));
            organizationSubjects.Add(new OrganizationSubject("47055", "TIS"));
        }

        public List<OrganizationSubject> GetAll()
        {
            return organizationSubjects;
        }
    }
}
