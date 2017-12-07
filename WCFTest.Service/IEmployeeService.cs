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
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "IEmployeeService"。
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        [WebGet(UriTemplate = "employee/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        EmployeeModel GetEmployeeByID(string id);

        [OperationContract]
        [WebInvoke(Method="POST",UriTemplate="employee",RequestFormat=WebMessageFormat.Json,ResponseFormat=WebMessageFormat.Json)]
        IEnumerable<EmployeeModel> AddEmployee(EmployeeModel e);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "employee", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<EmployeeModel> UpdateEmployee(EmployeeModel e);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "employee/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<EmployeeModel> DeleteEmployee(string id);


    }
}
