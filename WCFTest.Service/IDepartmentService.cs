using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using WCFTest.Model;

namespace WCFTest.Service
{
    [ServiceContract]
    public interface IDepartmentService
    {
        [OperationContract]
        [WebGet(UriTemplate="department/{id}",RequestFormat=WebMessageFormat.Json,ResponseFormat=WebMessageFormat.Json)]
        DepartmentModel GetDepartmentByID(string ID);

    }
}
