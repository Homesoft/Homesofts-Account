using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homesofts.Organizations.Service
{
    public class OrganizationService : IOrganizationService
    {
        IOrganizationRepository repository;
        public OrganizationService(IOrganizationRepository repository)
        {
            this.repository = repository;
        }

        public Models.Organization Create(Parameters.CreateParameter param)
        {
            param.Validate();
            assertEmailNotExist(param.Email);
            Models.Organization org = param.ParseToOrganization();
            repository.Insert(org);
            return org;
        }

        private void assertEmailNotExist(string email)
        {
            if (repository.Exist(email))
                throw new Exception(string.Format("Email {0} sudah terdaftar", email));
        }
    }
}
