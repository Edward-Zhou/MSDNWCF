using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using SilverlightApplication2.ServiceReference1;
using System.Threading.Tasks;

namespace SilverlightApplication2
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetCity();
        }
        private  void GetCity()
        {
            Service1Client client = new Service1Client();
            client.GetCurrentDateTimeCompleted += client_GetCurrentDateTimeCompleted;
            client.GetCurrentDateTimeAsync();
            //await Task.WaitAll(() => {new Task(){client.GetCurrentDateTimeAsync() }});
            
        }
        private void GetNum()
        {
            Service1Client client = new Service1Client();
            client.GetDataCompleted += client_GetDataCompleted;
            client.GetDataAsync(13);
            

        }

        void client_GetDataCompleted(object sender, GetDataCompletedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("client_GetDataCompleted");
        }

        void client_GetCurrentDateTimeCompleted(object sender, GetCurrentDateTimeCompletedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("client_GetCurrentDateTimeCompleted");
            GetNum();

        }
    }
}
