using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfParaSizeConsumer.ServiceReference1;

namespace WcfParaSizeConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            StudySize ss = new StudySize { Id=1, FileSize=1 };
            StudySize[] sourceStudies = new StudySize[600];
            for (int i = 0; i < sourceStudies.Count(); i++)
            {
                sourceStudies[i] = ss;
            }
            string result=client.GetMissingAndDifferentStudiesFromList(sourceStudies);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
