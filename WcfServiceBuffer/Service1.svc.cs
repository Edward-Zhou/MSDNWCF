using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceBuffer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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
        public void UploadFile(Stream stream)
        {
            int length = 0;
            using (FileStream write = new FileStream(@"D:\Edward\Project\MSDNWCF\WcfServiceBuffer\Test.docx", FileMode.Create))
            {
                int readCount;
                var buffer=new byte[8192];
                while((readCount=stream.Read(buffer,0,buffer.Length))!=0)
                {
                    write.Write(buffer,0,readCount);
                    length+=readCount;
                }
            }
        }
    }
}
