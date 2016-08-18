using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace WCFMessageFormatter
{
    public class MyCustomMessageFormatter : IDispatchMessageFormatter     
    {
        private readonly IDispatchMessageFormatter formatter;
        public MyCustomMessageFormatter(IDispatchMessageFormatter formatter) 
        {
            this.formatter = formatter;   
        }
        void IDispatchMessageFormatter.DeserializeRequest(System.ServiceModel.Channels.Message message, object[] parameters)
        {
            this.formatter.DeserializeRequest(message, parameters);
        }

        System.ServiceModel.Channels.Message IDispatchMessageFormatter.SerializeReply(System.ServiceModel.Channels.MessageVersion messageVersion, object[] parameters, object result)
        {
            var message = this.formatter.SerializeReply(messageVersion,parameters,result);
            System.ServiceModel.Channels.Message r = new MyCustomMessage(message);
            return r;
        }
    }
}