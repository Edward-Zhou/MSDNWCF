using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WCFTypeConsumer.ServiceReference1;

namespace WCFTypeConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            WCFTypeConsumer.ServiceReference1.CompositeType ct = new WCFTypeConsumer.ServiceReference1.CompositeType() { BoolValue = true, StringValue = "Hello " };
            WCFTypeConsumer.ServiceReference1.CompositeType cresult = client.GetDataUsingDataContract(ct);
            Console.WriteLine(cresult.StringValue);
            Console.ReadLine();
        }

    }
    [DataContract(Name = "WCFTypeConsumer.ServiceReference1.CompositeType")]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

}
