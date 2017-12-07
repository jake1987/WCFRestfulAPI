using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFTest.Model
{
    [DataContract]
    public class DepartmentModel
    {
        [DataMember]
        public string DepartID { get; set; }
        [DataMember]
        public string DepartName { get; set; }
    }
}
