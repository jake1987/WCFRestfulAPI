using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.Text;
using WCFTest.Model;
using System.Web;
using System.Net;

namespace WCFTest.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DepartmentService : IDepartmentService
    {
        private static IEnumerable<DepartmentModel> departments = new List<DepartmentModel> { 
            new DepartmentModel{DepartID="A001",DepartName="mis"},
            new DepartmentModel{DepartID="A002",DepartName="buyer"},
            new DepartmentModel{DepartID="A003",DepartName="sourcer"}
        };
        public DepartmentModel GetDepartmentByID(string ID)
        {
            var de = departments.FirstOrDefault(d => d.DepartID == ID);
            if (de == null)
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.NotFound;
            }
            return de;
        }
    }
}
