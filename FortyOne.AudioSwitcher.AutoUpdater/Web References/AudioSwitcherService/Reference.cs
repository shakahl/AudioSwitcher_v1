﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17626.
// 
#pragma warning disable 1591

namespace FortyOne.AudioSwitcher.AutoUpdater.AudioSwitcherService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AudioSwitcherSoap", Namespace="http://tempuri.org/")]
    public partial class AudioSwitcher : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CheckForUpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUpdateInfoOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendBugReportOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AudioSwitcher() {
            this.Url = global::FortyOne.AudioSwitcher.AutoUpdater.Properties.Settings.Default.FortyOne_AudioSwitcher_AutoUpdater_AudioSwitcherService_AudioSwitcher;
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
        public event CheckForUpdateCompletedEventHandler CheckForUpdateCompleted;
        
        /// <remarks/>
        public event GetUpdateInfoCompletedEventHandler GetUpdateInfoCompleted;
        
        /// <remarks/>
        public event SendBugReportCompletedEventHandler SendBugReportCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckForUpdate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CheckForUpdate(string assemblyVersion) {
            object[] results = this.Invoke("CheckForUpdate", new object[] {
                        assemblyVersion});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CheckForUpdateAsync(string assemblyVersion) {
            this.CheckForUpdateAsync(assemblyVersion, null);
        }
        
        /// <remarks/>
        public void CheckForUpdateAsync(string assemblyVersion, object userState) {
            if ((this.CheckForUpdateOperationCompleted == null)) {
                this.CheckForUpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckForUpdateOperationCompleted);
            }
            this.InvokeAsync("CheckForUpdate", new object[] {
                        assemblyVersion}, this.CheckForUpdateOperationCompleted, userState);
        }
        
        private void OnCheckForUpdateOperationCompleted(object arg) {
            if ((this.CheckForUpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckForUpdateCompleted(this, new CheckForUpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUpdateInfo", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public AudioSwitcherVersionInfo GetUpdateInfo(string assemblyVersion) {
            object[] results = this.Invoke("GetUpdateInfo", new object[] {
                        assemblyVersion});
            return ((AudioSwitcherVersionInfo)(results[0]));
        }
        
        /// <remarks/>
        public void GetUpdateInfoAsync(string assemblyVersion) {
            this.GetUpdateInfoAsync(assemblyVersion, null);
        }
        
        /// <remarks/>
        public void GetUpdateInfoAsync(string assemblyVersion, object userState) {
            if ((this.GetUpdateInfoOperationCompleted == null)) {
                this.GetUpdateInfoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUpdateInfoOperationCompleted);
            }
            this.InvokeAsync("GetUpdateInfo", new object[] {
                        assemblyVersion}, this.GetUpdateInfoOperationCompleted, userState);
        }
        
        private void OnGetUpdateInfoOperationCompleted(object arg) {
            if ((this.GetUpdateInfoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUpdateInfoCompleted(this, new GetUpdateInfoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SendBugReport", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SendBugReport(string confirmation, string userComment, string details, string stackTrace) {
            object[] results = this.Invoke("SendBugReport", new object[] {
                        confirmation,
                        userComment,
                        details,
                        stackTrace});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void SendBugReportAsync(string confirmation, string userComment, string details, string stackTrace) {
            this.SendBugReportAsync(confirmation, userComment, details, stackTrace, null);
        }
        
        /// <remarks/>
        public void SendBugReportAsync(string confirmation, string userComment, string details, string stackTrace, object userState) {
            if ((this.SendBugReportOperationCompleted == null)) {
                this.SendBugReportOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendBugReportOperationCompleted);
            }
            this.InvokeAsync("SendBugReport", new object[] {
                        confirmation,
                        userComment,
                        details,
                        stackTrace}, this.SendBugReportOperationCompleted, userState);
        }
        
        private void OnSendBugReportOperationCompleted(object arg) {
            if ((this.SendBugReportCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendBugReportCompleted(this, new SendBugReportCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17626")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AudioSwitcherVersionInfo {
        
        private string versionInfoField;
        
        private string uRLField;
        
        private string changeLogField;
        
        /// <remarks/>
        public string VersionInfo {
            get {
                return this.versionInfoField;
            }
            set {
                this.versionInfoField = value;
            }
        }
        
        /// <remarks/>
        public string URL {
            get {
                return this.uRLField;
            }
            set {
                this.uRLField = value;
            }
        }
        
        /// <remarks/>
        public string ChangeLog {
            get {
                return this.changeLogField;
            }
            set {
                this.changeLogField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    public delegate void CheckForUpdateCompletedEventHandler(object sender, CheckForUpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckForUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckForUpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    public delegate void GetUpdateInfoCompletedEventHandler(object sender, GetUpdateInfoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUpdateInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUpdateInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public AudioSwitcherVersionInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((AudioSwitcherVersionInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    public delegate void SendBugReportCompletedEventHandler(object sender, SendBugReportCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17626")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendBugReportCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendBugReportCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591