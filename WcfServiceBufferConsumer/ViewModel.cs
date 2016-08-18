using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WcfServiceBufferConsumer.ServiceReference1;

namespace WcfServiceBufferConsumer
{
     class ViewModel
    {
        public DateTime currentDateTime;
         public async Task getDateTime()
         {
             Service1Client client = new Service1Client();
             client.GetCurrentDateTimeCompleted += client_GetCurrentDateTimeCompleted;
             client.GetCurrentDateTimeAsync();
              
             //await Task.Run(() => {
             //    client.GetCurrentDateTimeAsync();
             //}); 

         }
        internal void GetDateTime()
        {
            Service1Client client=new Service1Client();
            client.GetCurrentDateTimeCompleted+=client_GetCurrentDateTimeCompleted;
            client.GetCurrentDateTimeAsync();
            Console.WriteLine("GetTime"+Thread.CurrentThread.ManagedThreadId);
            //await getDateTime(client);
            //client.GetCurrentDateTimeAsync();
            // client.GetCurrentDateTime();
        }

        void client_GetCurrentDateTimeCompleted(object sender, GetCurrentDateTimeCompletedEventArgs e)
        {
            Console.WriteLine("complete"+Thread.CurrentThread.ManagedThreadId);
            if (e.Error == null && e.Result != null)
            {
                currentDateTime = e.Result;

            }
            Console.WriteLine("client_GetCurrentDateTimeCompleted");
        }
    }
}
