using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WcfParameter;

namespace WcfParameterConsumer1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Service1Client client = new Service1Client();
            //CompositeType composite = new CompositeType {  BoolValue=true, StringValue="Test1" };
            //CompositeType composite1 = new CompositeType { BoolValue = true, StringValue = "Test2" };
            //CompositeType[] c = new CompositeType[] { composite, composite1};
            //UserInfo u=new UserInfo{ Id=1, Name="User"};
            //client.GetDataUsingDataContract(u,out c);
            GetSubject();
        }

        public static void GetSubject()
        {
            X509Certificate2Collection certs = new X509Certificate2Collection();
            // grab candidates from CA and Root stores
            foreach (var storeName in new[] { StoreName.My })
            {
                X509Store store = new X509Store(storeName, StoreLocation.CurrentUser);
                store.Open(OpenFlags.ReadOnly);
                certs.AddRange(store.Certificates);
                store.Close();
            }
            certs = certs.Find(X509FindType.FindByIssuerName, "MSIT Enterprise CA 1", false);
            if (certs.Count == 0)
            {
                Console.WriteLine("Issuer is not installed in the local certificate store.");
                return;
            }
            var aki = certs[0].Extensions["2.5.29.35"];
            if (aki == null)
            {
                Console.WriteLine("Issuer candidates: ");
                foreach (var candidate in certs)
                {
                    Console.WriteLine(candidate.Thumbprint);
                }
                return;
            }
            var match = Regex.Match(aki.Format(false), "KeyID=(.+)", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                var keyid = match.Groups[1].Value.Replace(" ", null).ToUpper();
                Console.WriteLine("Issuer candidates: ");
                foreach (var candidate in certs.Find(X509FindType.FindBySubjectKeyIdentifier, keyid, false))
                {
                    Console.WriteLine(candidate.Thumbprint);
                }
            }
            else
            {
                // if KeyID is not presented in the AKI extension, attempt to get serial number from AKI:
                match = Regex.Match(aki.Format(false), "Certificate SerialNumber=(.+)", RegexOptions.IgnoreCase);
                var serial = match.Groups[1].Value.Replace(" ", null);
                Console.WriteLine("Issuer candidates: ");
                foreach (var candidate in certs.Find(X509FindType.FindBySerialNumber, serial, false))
                {
                    Console.WriteLine(candidate.Thumbprint);
                }
            }
        }
    }
}
