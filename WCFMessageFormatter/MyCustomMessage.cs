using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace WCFMessageFormatter
{
    public class MyCustomMessage:Message
    {
        private readonly Message message;
        public MyCustomMessage(Message message)
        {
            this.message = message;
        }

        public override MessageHeaders Headers
        {
            get { return this.message.Headers; }
        }

        public override MessageProperties Properties
        {
            get { return this.message.Properties; }
        }

        public override MessageVersion Version
        {
            get { return this.message.Version; }
        }
        protected override void OnWriteStartBody(System.Xml.XmlDictionaryWriter writer)
        {
            writer.WriteStartElement("Body", "http://schemas.xmlsoap.org/soap/envelope/");
        }
        protected override void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer)
        {
            this.message.WriteBodyContents(writer);
        }
        //protected override void OnWriteStartHeaders(System.Xml.XmlDictionaryWriter writer)
        //{
        //    writer.WriteStartElement("Header", "http://schemas.xmlsoap.org/soap/envelope/");
            
        //}

        protected override void OnWriteStartEnvelope(System.Xml.XmlDictionaryWriter writer)
        {
            writer.WriteStartElement("soapenv", "Envelope", "http://schemas.xmlsoap.org/soap/envelope/");

            writer.WriteAttributeString("xmlns", "c2b", null, "http://cps.huawei.com/cpsinterface/c2bpayment");
        }

    }
}
