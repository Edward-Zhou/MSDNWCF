using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Security.Principal;
using System.IO;

namespace WCFDelegation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        [OperationBehavior(Impersonation=ImpersonationOption.Required)]
        public string GetData(int value)
        {
            string user = WindowsIdentity.GetCurrent().Name;
            try {
                string result=File.ReadAllText(@"D:\Edward\Project\MSDNWCF\WCFDelegation\Test.txt");
                Console.WriteLine("Content is " + result);
                return string.Format("{0} entered: {1}", WindowsIdentity.GetCurrent().Name, result);
            }
            catch(Exception e)
            {
                Console.WriteLine("error is "+ e.ToString());
                return string.Format("{0} entered: {1}", WindowsIdentity.GetCurrent().Name, e.ToString());
            }

        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
