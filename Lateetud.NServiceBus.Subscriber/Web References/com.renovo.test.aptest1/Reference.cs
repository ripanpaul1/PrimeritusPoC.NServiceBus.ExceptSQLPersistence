﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Lateetud.NServiceBus.Subscriber.com.renovo.test.aptest1 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EM1_ASG_NOTE_UPDATESoap", Namespace="http://tempuri.org/")]
    public partial class EM1_ASG_NOTE_UPDATE : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback _EM1_ASG_NOTE_UPDATEOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public EM1_ASG_NOTE_UPDATE() {
            this.Url = global::Lateetud.NServiceBus.Subscriber.Properties.Settings.Default.Lateetud_NServiceBus_Subscriber_com_renovo_test_aptest1_EM1_ASG_NOTE_UPDATE;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event _EM1_ASG_NOTE_UPDATECompletedEventHandler _EM1_ASG_NOTE_UPDATECompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/_EM1_ASG_NOTE_UPDATE", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int _EM1_ASG_NOTE_UPDATE(string Datos) {
            object[] results = this.Invoke("_EM1_ASG_NOTE_UPDATE", new object[] {
                        Datos});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void _EM1_ASG_NOTE_UPDATEAsync(string Datos) {
            this._EM1_ASG_NOTE_UPDATEAsync(Datos, null);
        }
        
        /// <remarks/>
        public void _EM1_ASG_NOTE_UPDATEAsync(string Datos, object userState) {
            if ((this._EM1_ASG_NOTE_UPDATEOperationCompleted == null)) {
                this._EM1_ASG_NOTE_UPDATEOperationCompleted = new System.Threading.SendOrPostCallback(this.On_EM1_ASG_NOTE_UPDATEOperationCompleted);
            }
            this.InvokeAsync("_EM1_ASG_NOTE_UPDATE", new object[] {
                        Datos}, this._EM1_ASG_NOTE_UPDATEOperationCompleted, userState);
        }
        
        private void On_EM1_ASG_NOTE_UPDATEOperationCompleted(object arg) {
            if ((this._EM1_ASG_NOTE_UPDATECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this._EM1_ASG_NOTE_UPDATECompleted(this, new _EM1_ASG_NOTE_UPDATECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void _EM1_ASG_NOTE_UPDATECompletedEventHandler(object sender, _EM1_ASG_NOTE_UPDATECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class _EM1_ASG_NOTE_UPDATECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal _EM1_ASG_NOTE_UPDATECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591