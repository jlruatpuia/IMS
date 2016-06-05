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

namespace IMS.wrPurchases {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="wsPurchasesSoap", Namespace="http://tempuri.org/")]
    public partial class wsPurchases : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback addPurchaseOperationCompleted;
        
        private System.Threading.SendOrPostCallback addPurchaseDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPurchasedProductsByDateOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPurchasedProductsByDatesOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPurchasedProductsByInvoiceOperationCompleted;
        
        private System.Threading.SendOrPostCallback PurchaseFromSupplierByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback PurchaseFromSupplierByDatesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public wsPurchases() {
            this.Url = global::IMS.Properties.Settings.Default.IMS_wrPurchases_wsPurchases;
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
        public event addPurchaseCompletedEventHandler addPurchaseCompleted;
        
        /// <remarks/>
        public event addPurchaseDetailsCompletedEventHandler addPurchaseDetailsCompleted;
        
        /// <remarks/>
        public event getPurchasedProductsByDateCompletedEventHandler getPurchasedProductsByDateCompleted;
        
        /// <remarks/>
        public event getPurchasedProductsByDatesCompletedEventHandler getPurchasedProductsByDatesCompleted;
        
        /// <remarks/>
        public event getPurchasedProductsByInvoiceCompletedEventHandler getPurchasedProductsByInvoiceCompleted;
        
        /// <remarks/>
        public event PurchaseFromSupplierByIDCompletedEventHandler PurchaseFromSupplierByIDCompleted;
        
        /// <remarks/>
        public event PurchaseFromSupplierByDatesCompletedEventHandler PurchaseFromSupplierByDatesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addPurchase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client addPurchase(Purchase p) {
            object[] results = this.Invoke("addPurchase", new object[] {
                        p});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void addPurchaseAsync(Purchase p) {
            this.addPurchaseAsync(p, null);
        }
        
        /// <remarks/>
        public void addPurchaseAsync(Purchase p, object userState) {
            if ((this.addPurchaseOperationCompleted == null)) {
                this.addPurchaseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddPurchaseOperationCompleted);
            }
            this.InvokeAsync("addPurchase", new object[] {
                        p}, this.addPurchaseOperationCompleted, userState);
        }
        
        private void OnaddPurchaseOperationCompleted(object arg) {
            if ((this.addPurchaseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addPurchaseCompleted(this, new addPurchaseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addPurchaseDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client addPurchaseDetails(PurchaseDetail p) {
            object[] results = this.Invoke("addPurchaseDetails", new object[] {
                        p});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void addPurchaseDetailsAsync(PurchaseDetail p) {
            this.addPurchaseDetailsAsync(p, null);
        }
        
        /// <remarks/>
        public void addPurchaseDetailsAsync(PurchaseDetail p, object userState) {
            if ((this.addPurchaseDetailsOperationCompleted == null)) {
                this.addPurchaseDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddPurchaseDetailsOperationCompleted);
            }
            this.InvokeAsync("addPurchaseDetails", new object[] {
                        p}, this.addPurchaseDetailsOperationCompleted, userState);
        }
        
        private void OnaddPurchaseDetailsOperationCompleted(object arg) {
            if ((this.addPurchaseDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addPurchaseDetailsCompleted(this, new addPurchaseDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getPurchasedProductsByDate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client getPurchasedProductsByDate(System.DateTime dt) {
            object[] results = this.Invoke("getPurchasedProductsByDate", new object[] {
                        dt});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void getPurchasedProductsByDateAsync(System.DateTime dt) {
            this.getPurchasedProductsByDateAsync(dt, null);
        }
        
        /// <remarks/>
        public void getPurchasedProductsByDateAsync(System.DateTime dt, object userState) {
            if ((this.getPurchasedProductsByDateOperationCompleted == null)) {
                this.getPurchasedProductsByDateOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPurchasedProductsByDateOperationCompleted);
            }
            this.InvokeAsync("getPurchasedProductsByDate", new object[] {
                        dt}, this.getPurchasedProductsByDateOperationCompleted, userState);
        }
        
        private void OngetPurchasedProductsByDateOperationCompleted(object arg) {
            if ((this.getPurchasedProductsByDateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPurchasedProductsByDateCompleted(this, new getPurchasedProductsByDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getPurchasedProductsByDates", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client getPurchasedProductsByDates(System.DateTime dtFr, System.DateTime dtTo) {
            object[] results = this.Invoke("getPurchasedProductsByDates", new object[] {
                        dtFr,
                        dtTo});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void getPurchasedProductsByDatesAsync(System.DateTime dtFr, System.DateTime dtTo) {
            this.getPurchasedProductsByDatesAsync(dtFr, dtTo, null);
        }
        
        /// <remarks/>
        public void getPurchasedProductsByDatesAsync(System.DateTime dtFr, System.DateTime dtTo, object userState) {
            if ((this.getPurchasedProductsByDatesOperationCompleted == null)) {
                this.getPurchasedProductsByDatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPurchasedProductsByDatesOperationCompleted);
            }
            this.InvokeAsync("getPurchasedProductsByDates", new object[] {
                        dtFr,
                        dtTo}, this.getPurchasedProductsByDatesOperationCompleted, userState);
        }
        
        private void OngetPurchasedProductsByDatesOperationCompleted(object arg) {
            if ((this.getPurchasedProductsByDatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPurchasedProductsByDatesCompleted(this, new getPurchasedProductsByDatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getPurchasedProductsByInvoice", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client getPurchasedProductsByInvoice(string InvoiceNo) {
            object[] results = this.Invoke("getPurchasedProductsByInvoice", new object[] {
                        InvoiceNo});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void getPurchasedProductsByInvoiceAsync(string InvoiceNo) {
            this.getPurchasedProductsByInvoiceAsync(InvoiceNo, null);
        }
        
        /// <remarks/>
        public void getPurchasedProductsByInvoiceAsync(string InvoiceNo, object userState) {
            if ((this.getPurchasedProductsByInvoiceOperationCompleted == null)) {
                this.getPurchasedProductsByInvoiceOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPurchasedProductsByInvoiceOperationCompleted);
            }
            this.InvokeAsync("getPurchasedProductsByInvoice", new object[] {
                        InvoiceNo}, this.getPurchasedProductsByInvoiceOperationCompleted, userState);
        }
        
        private void OngetPurchasedProductsByInvoiceOperationCompleted(object arg) {
            if ((this.getPurchasedProductsByInvoiceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPurchasedProductsByInvoiceCompleted(this, new getPurchasedProductsByInvoiceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PurchaseFromSupplierByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client PurchaseFromSupplierByID(int SupplierID) {
            object[] results = this.Invoke("PurchaseFromSupplierByID", new object[] {
                        SupplierID});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void PurchaseFromSupplierByIDAsync(int SupplierID) {
            this.PurchaseFromSupplierByIDAsync(SupplierID, null);
        }
        
        /// <remarks/>
        public void PurchaseFromSupplierByIDAsync(int SupplierID, object userState) {
            if ((this.PurchaseFromSupplierByIDOperationCompleted == null)) {
                this.PurchaseFromSupplierByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPurchaseFromSupplierByIDOperationCompleted);
            }
            this.InvokeAsync("PurchaseFromSupplierByID", new object[] {
                        SupplierID}, this.PurchaseFromSupplierByIDOperationCompleted, userState);
        }
        
        private void OnPurchaseFromSupplierByIDOperationCompleted(object arg) {
            if ((this.PurchaseFromSupplierByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PurchaseFromSupplierByIDCompleted(this, new PurchaseFromSupplierByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/PurchaseFromSupplierByDates", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Server2Client PurchaseFromSupplierByDates(int SupplierID, System.DateTime dtFr, System.DateTime dtTo) {
            object[] results = this.Invoke("PurchaseFromSupplierByDates", new object[] {
                        SupplierID,
                        dtFr,
                        dtTo});
            return ((Server2Client)(results[0]));
        }
        
        /// <remarks/>
        public void PurchaseFromSupplierByDatesAsync(int SupplierID, System.DateTime dtFr, System.DateTime dtTo) {
            this.PurchaseFromSupplierByDatesAsync(SupplierID, dtFr, dtTo, null);
        }
        
        /// <remarks/>
        public void PurchaseFromSupplierByDatesAsync(int SupplierID, System.DateTime dtFr, System.DateTime dtTo, object userState) {
            if ((this.PurchaseFromSupplierByDatesOperationCompleted == null)) {
                this.PurchaseFromSupplierByDatesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPurchaseFromSupplierByDatesOperationCompleted);
            }
            this.InvokeAsync("PurchaseFromSupplierByDates", new object[] {
                        SupplierID,
                        dtFr,
                        dtTo}, this.PurchaseFromSupplierByDatesOperationCompleted, userState);
        }
        
        private void OnPurchaseFromSupplierByDatesOperationCompleted(object arg) {
            if ((this.PurchaseFromSupplierByDatesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PurchaseFromSupplierByDatesCompleted(this, new PurchaseFromSupplierByDatesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Purchase {
        
        private int purchaseIDField;
        
        private string invoiceNoField;
        
        private System.DateTime purchaseDateField;
        
        private int supplierIDField;
        
        private double amountField;
        
        private double paymentField;
        
        private double balanceField;
        
        /// <remarks/>
        public int PurchaseID {
            get {
                return this.purchaseIDField;
            }
            set {
                this.purchaseIDField = value;
            }
        }
        
        /// <remarks/>
        public string InvoiceNo {
            get {
                return this.invoiceNoField;
            }
            set {
                this.invoiceNoField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime PurchaseDate {
            get {
                return this.purchaseDateField;
            }
            set {
                this.purchaseDateField = value;
            }
        }
        
        /// <remarks/>
        public int SupplierID {
            get {
                return this.supplierIDField;
            }
            set {
                this.supplierIDField = value;
            }
        }
        
        /// <remarks/>
        public double Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public double Payment {
            get {
                return this.paymentField;
            }
            set {
                this.paymentField = value;
            }
        }
        
        /// <remarks/>
        public double Balance {
            get {
                return this.balanceField;
            }
            set {
                this.balanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class PurchaseDetail {
        
        private int purchaseDetailIDField;
        
        private string invoiceNoField;
        
        private string productCodeField;
        
        private double buyingValueField;
        
        private double sellingValueField;
        
        private int quantityField;
        
        private double amountField;
        
        /// <remarks/>
        public int PurchaseDetailID {
            get {
                return this.purchaseDetailIDField;
            }
            set {
                this.purchaseDetailIDField = value;
            }
        }
        
        /// <remarks/>
        public string InvoiceNo {
            get {
                return this.invoiceNoField;
            }
            set {
                this.invoiceNoField = value;
            }
        }
        
        /// <remarks/>
        public string ProductCode {
            get {
                return this.productCodeField;
            }
            set {
                this.productCodeField = value;
            }
        }
        
        /// <remarks/>
        public double BuyingValue {
            get {
                return this.buyingValueField;
            }
            set {
                this.buyingValueField = value;
            }
        }
        
        /// <remarks/>
        public double SellingValue {
            get {
                return this.sellingValueField;
            }
            set {
                this.sellingValueField = value;
            }
        }
        
        /// <remarks/>
        public int Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public double Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Server2Client {
        
        private int countField;
        
        private double valueField;
        
        private string messageField;
        
        private System.Data.DataTable dataTableField;
        
        private System.Data.DataSet dataSetField;
        
        /// <remarks/>
        public int Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        public double Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        public System.Data.DataTable dataTable {
            get {
                return this.dataTableField;
            }
            set {
                this.dataTableField = value;
            }
        }
        
        /// <remarks/>
        public System.Data.DataSet dataSet {
            get {
                return this.dataSetField;
            }
            set {
                this.dataSetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void addPurchaseCompletedEventHandler(object sender, addPurchaseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addPurchaseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addPurchaseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void addPurchaseDetailsCompletedEventHandler(object sender, addPurchaseDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addPurchaseDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addPurchaseDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void getPurchasedProductsByDateCompletedEventHandler(object sender, getPurchasedProductsByDateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPurchasedProductsByDateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPurchasedProductsByDateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void getPurchasedProductsByDatesCompletedEventHandler(object sender, getPurchasedProductsByDatesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPurchasedProductsByDatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPurchasedProductsByDatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void getPurchasedProductsByInvoiceCompletedEventHandler(object sender, getPurchasedProductsByInvoiceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPurchasedProductsByInvoiceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPurchasedProductsByInvoiceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void PurchaseFromSupplierByIDCompletedEventHandler(object sender, PurchaseFromSupplierByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PurchaseFromSupplierByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PurchaseFromSupplierByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void PurchaseFromSupplierByDatesCompletedEventHandler(object sender, PurchaseFromSupplierByDatesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PurchaseFromSupplierByDatesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PurchaseFromSupplierByDatesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Server2Client Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Server2Client)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591