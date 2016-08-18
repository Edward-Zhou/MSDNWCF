using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDownLoadFileConsumer.ServiceReference1;

namespace WCFDownLoadFileConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Test.txt";
            string TargetFilePath = @"D:\Edward\Project\MSDNWCF\WCFDownLoadFile\App_Data\"+fileName;
            Service1Client client = new Service1Client();
            Stream fileStream = client.DownLoadFile(fileName);
            using (var file = new FileStream(TargetFilePath, FileMode.Create, FileAccess.Write))
            {
                fileStream.CopyTo(file);
            }
            Console.WriteLine("Down load file is ok!");
        }
    }
}
