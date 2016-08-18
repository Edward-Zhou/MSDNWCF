using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace MSDNWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public string OCRImage(Stream fileStream)
        {
            string FilePath = @"D:\Edward\Project\MSDNWCF\MSDNWCF\App_Data\test.png";

            int length = 0;
            using (FileStream writer = new FileStream(FilePath, FileMode.Create))
            {
                int readCount;
                var buffer = new byte[8192];
                while ((readCount = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    writer.Write(buffer, 0, readCount);
                    length += readCount;
                }
            }
            return "file upload is ok";
        }
        public bool ImageByte(byte[] fileByte)
        {
            string FilePath = @"D:\Edward\Project\MSDNWCF\MSDNWCF\App_Data\ImageByte.png";
            using (FileStream write = new FileStream(FilePath, FileMode.Create))
            {
                try
                {
                    //write.Write(fileByte, 0, fileByte.Length);
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }
        public string getStream()
        {

            return "ok";
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite, UserInfo user)
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
