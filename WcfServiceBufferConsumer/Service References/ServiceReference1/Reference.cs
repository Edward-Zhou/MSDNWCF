﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceBufferConsumer.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceBuffer")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.IAsyncResult BeginGetData(int value, System.AsyncCallback callback, object asyncState);
        
        string EndGetData(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WcfServiceBufferConsumer.ServiceReference1.CompositeType GetDataUsingDataContract(WcfServiceBufferConsumer.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.IAsyncResult BeginGetDataUsingDataContract(WcfServiceBufferConsumer.ServiceReference1.CompositeType composite, System.AsyncCallback callback, object asyncState);
        
        WcfServiceBufferConsumer.ServiceReference1.CompositeType EndGetDataUsingDataContract(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UploadFile", ReplyAction="http://tempuri.org/IService1/UploadFileResponse")]
        void UploadFile(System.IO.Stream stream);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/UploadFile", ReplyAction="http://tempuri.org/IService1/UploadFileResponse")]
        System.IAsyncResult BeginUploadFile(System.IO.Stream stream, System.AsyncCallback callback, object asyncState);
        
        void EndUploadFile(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCurrentDateTime", ReplyAction="http://tempuri.org/IService1/GetCurrentDateTimeResponse")]
        System.DateTime GetCurrentDateTime();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IService1/GetCurrentDateTime", ReplyAction="http://tempuri.org/IService1/GetCurrentDateTimeResponse")]
        System.IAsyncResult BeginGetCurrentDateTime(System.AsyncCallback callback, object asyncState);
        
        System.DateTime EndGetCurrentDateTime(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfServiceBufferConsumer.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public WcfServiceBufferConsumer.ServiceReference1.CompositeType Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((WcfServiceBufferConsumer.ServiceReference1.CompositeType)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCurrentDateTimeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCurrentDateTimeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.DateTime Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.DateTime)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfServiceBufferConsumer.ServiceReference1.IService1>, WcfServiceBufferConsumer.ServiceReference1.IService1 {
        
        private BeginOperationDelegate onBeginGetDataDelegate;
        
        private EndOperationDelegate onEndGetDataDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetDataUsingDataContractDelegate;
        
        private EndOperationDelegate onEndGetDataUsingDataContractDelegate;
        
        private System.Threading.SendOrPostCallback onGetDataUsingDataContractCompletedDelegate;
        
        private BeginOperationDelegate onBeginUploadFileDelegate;
        
        private EndOperationDelegate onEndUploadFileDelegate;
        
        private System.Threading.SendOrPostCallback onUploadFileCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetCurrentDateTimeDelegate;
        
        private EndOperationDelegate onEndGetCurrentDateTimeDelegate;
        
        private System.Threading.SendOrPostCallback onGetCurrentDateTimeCompletedDelegate;
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetDataCompletedEventArgs> GetDataCompleted;
        
        public event System.EventHandler<GetDataUsingDataContractCompletedEventArgs> GetDataUsingDataContractCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UploadFileCompleted;
        
        public event System.EventHandler<GetCurrentDateTimeCompletedEventArgs> GetCurrentDateTimeCompleted;
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetData(int value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetData(value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetData(System.IAsyncResult result) {
            return base.Channel.EndGetData(result);
        }
        
        private System.IAsyncResult OnBeginGetData(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int value = ((int)(inValues[0]));
            return this.BeginGetData(value, callback, asyncState);
        }
        
        private object[] OnEndGetData(System.IAsyncResult result) {
            string retVal = this.EndGetData(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataCompleted(object state) {
            if ((this.GetDataCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataAsync(int value) {
            this.GetDataAsync(value, null);
        }
        
        public void GetDataAsync(int value, object userState) {
            if ((this.onBeginGetDataDelegate == null)) {
                this.onBeginGetDataDelegate = new BeginOperationDelegate(this.OnBeginGetData);
            }
            if ((this.onEndGetDataDelegate == null)) {
                this.onEndGetDataDelegate = new EndOperationDelegate(this.OnEndGetData);
            }
            if ((this.onGetDataCompletedDelegate == null)) {
                this.onGetDataCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataDelegate, new object[] {
                        value}, this.onEndGetDataDelegate, this.onGetDataCompletedDelegate, userState);
        }
        
        public WcfServiceBufferConsumer.ServiceReference1.CompositeType GetDataUsingDataContract(WcfServiceBufferConsumer.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetDataUsingDataContract(WcfServiceBufferConsumer.ServiceReference1.CompositeType composite, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetDataUsingDataContract(composite, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public WcfServiceBufferConsumer.ServiceReference1.CompositeType EndGetDataUsingDataContract(System.IAsyncResult result) {
            return base.Channel.EndGetDataUsingDataContract(result);
        }
        
        private System.IAsyncResult OnBeginGetDataUsingDataContract(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WcfServiceBufferConsumer.ServiceReference1.CompositeType composite = ((WcfServiceBufferConsumer.ServiceReference1.CompositeType)(inValues[0]));
            return this.BeginGetDataUsingDataContract(composite, callback, asyncState);
        }
        
        private object[] OnEndGetDataUsingDataContract(System.IAsyncResult result) {
            WcfServiceBufferConsumer.ServiceReference1.CompositeType retVal = this.EndGetDataUsingDataContract(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetDataUsingDataContractCompleted(object state) {
            if ((this.GetDataUsingDataContractCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetDataUsingDataContractAsync(WcfServiceBufferConsumer.ServiceReference1.CompositeType composite) {
            this.GetDataUsingDataContractAsync(composite, null);
        }
        
        public void GetDataUsingDataContractAsync(WcfServiceBufferConsumer.ServiceReference1.CompositeType composite, object userState) {
            if ((this.onBeginGetDataUsingDataContractDelegate == null)) {
                this.onBeginGetDataUsingDataContractDelegate = new BeginOperationDelegate(this.OnBeginGetDataUsingDataContract);
            }
            if ((this.onEndGetDataUsingDataContractDelegate == null)) {
                this.onEndGetDataUsingDataContractDelegate = new EndOperationDelegate(this.OnEndGetDataUsingDataContract);
            }
            if ((this.onGetDataUsingDataContractCompletedDelegate == null)) {
                this.onGetDataUsingDataContractCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractCompleted);
            }
            base.InvokeAsync(this.onBeginGetDataUsingDataContractDelegate, new object[] {
                        composite}, this.onEndGetDataUsingDataContractDelegate, this.onGetDataUsingDataContractCompletedDelegate, userState);
        }
        
        public void UploadFile(System.IO.Stream stream) {
            base.Channel.UploadFile(stream);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginUploadFile(System.IO.Stream stream, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUploadFile(stream, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndUploadFile(System.IAsyncResult result) {
            base.Channel.EndUploadFile(result);
        }
        
        private System.IAsyncResult OnBeginUploadFile(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.IO.Stream stream = ((System.IO.Stream)(inValues[0]));
            return this.BeginUploadFile(stream, callback, asyncState);
        }
        
        private object[] OnEndUploadFile(System.IAsyncResult result) {
            this.EndUploadFile(result);
            return null;
        }
        
        private void OnUploadFileCompleted(object state) {
            if ((this.UploadFileCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UploadFileCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UploadFileAsync(System.IO.Stream stream) {
            this.UploadFileAsync(stream, null);
        }
        
        public void UploadFileAsync(System.IO.Stream stream, object userState) {
            if ((this.onBeginUploadFileDelegate == null)) {
                this.onBeginUploadFileDelegate = new BeginOperationDelegate(this.OnBeginUploadFile);
            }
            if ((this.onEndUploadFileDelegate == null)) {
                this.onEndUploadFileDelegate = new EndOperationDelegate(this.OnEndUploadFile);
            }
            if ((this.onUploadFileCompletedDelegate == null)) {
                this.onUploadFileCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUploadFileCompleted);
            }
            base.InvokeAsync(this.onBeginUploadFileDelegate, new object[] {
                        stream}, this.onEndUploadFileDelegate, this.onUploadFileCompletedDelegate, userState);
        }
        
        public System.DateTime GetCurrentDateTime() {
            return base.Channel.GetCurrentDateTime();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetCurrentDateTime(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetCurrentDateTime(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.DateTime EndGetCurrentDateTime(System.IAsyncResult result) {
            return base.Channel.EndGetCurrentDateTime(result);
        }
        
        private System.IAsyncResult OnBeginGetCurrentDateTime(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetCurrentDateTime(callback, asyncState);
        }
        
        private object[] OnEndGetCurrentDateTime(System.IAsyncResult result) {
            System.DateTime retVal = this.EndGetCurrentDateTime(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCurrentDateTimeCompleted(object state) {
            if ((this.GetCurrentDateTimeCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCurrentDateTimeCompleted(this, new GetCurrentDateTimeCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetCurrentDateTimeAsync() {
            this.GetCurrentDateTimeAsync(null);
        }
        
        public void GetCurrentDateTimeAsync(object userState) {
            if ((this.onBeginGetCurrentDateTimeDelegate == null)) {
                this.onBeginGetCurrentDateTimeDelegate = new BeginOperationDelegate(this.OnBeginGetCurrentDateTime);
            }
            if ((this.onEndGetCurrentDateTimeDelegate == null)) {
                this.onEndGetCurrentDateTimeDelegate = new EndOperationDelegate(this.OnEndGetCurrentDateTime);
            }
            if ((this.onGetCurrentDateTimeCompletedDelegate == null)) {
                this.onGetCurrentDateTimeCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCurrentDateTimeCompleted);
            }
            base.InvokeAsync(this.onBeginGetCurrentDateTimeDelegate, null, this.onEndGetCurrentDateTimeDelegate, this.onGetCurrentDateTimeCompletedDelegate, userState);
        }
    }
}
