using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homesofts.Organizations.Service
{
    public interface IOrganizationRepository
    {
        bool Exist(string email);

        void Insert(Models.Organization org);
    }
}
