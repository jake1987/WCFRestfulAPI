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
    public class EmployeeService : IEmployeeService
    {
        private static List<EmployeeModel> employees = new List<EmployeeModel>
        {
            new EmployeeModel{ Id = "001", Name="万事通", Department="开发部", Grade = "G4"},
            new EmployeeModel{ Id = "002", Name="害羞鬼", Department="人事部", Grade = "G6"}
        };
        public EmployeeModel GetEmployeeByID(string id)
        {
            EmployeeModel e = employees.FirstOrDefault(em => em.Id == id);
            if (null == e)
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.NotFound;
            }
            return e;
        }
        public IEnumerable<EmployeeModel> AddEmployee(EmployeeModel e)
        {
            //请求header
            //添加Content-Type: application/json; charset=utf-8
            //否则会返回400,bad request
            employees.Add(e);
            return employees;
        }

        public IEnumerable<EmployeeModel> UpdateEmployee(EmployeeModel e)
        {
            var e1= employees.Find(em => em.Id == e.Id);
            employees.Remove(e1);
            employees.Add(e);
            return employees;
        }

        public IEnumerable<EmployeeModel> DeleteEmployee(string id)
        {
            return employees;
        }
    }
}
