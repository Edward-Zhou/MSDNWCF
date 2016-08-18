using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace WCFMessageFormatter
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MobilityProviderFormatMessageAttribute:Attribute,IOperationBehavior
    {

        public void AddBindingParameters(OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation)
        {
            //IClientMessageFormatter currentFormatter = clientOperation.Formatter;
            //clientOperation.Formatter = new MyCustomClientMessageFormatter(currentFormatter);
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation)
        {

            var serializerBehavior = operationDescription.Behaviors.Find<DataContractSerializerOperationBehavior>();
            if (dispatchOperation.Formatter == null)
            {
                ((IOperationBehavior)serializerBehavior).ApplyDispatchBehavior(operationDescription, dispatchOperation);
            }

            IDispatchMessageFormatter innerDispatchFormatter = dispatchOperation.Formatter;

            dispatchOperation.Formatter = new MyCustomMessageFormatter(innerDispatchFormatter);
            

        }

        public void Validate(OperationDescription operationDescription)
        {
            
        }
    }
}