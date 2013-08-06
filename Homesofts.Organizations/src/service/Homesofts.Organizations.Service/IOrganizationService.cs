using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homesofts.Organizations.Service
{
    public interface IOrganizationService
    {
        Models.Organization Create(Parameters.CreateParameter param);
    }
}
