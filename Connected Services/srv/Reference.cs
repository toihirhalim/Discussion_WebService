﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Discussion.srv {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Participant", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Participant : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PseudoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Pseudo {
            get {
                return this.PseudoField;
            }
            set {
                if ((object.ReferenceEquals(this.PseudoField, value) != true)) {
                    this.PseudoField = value;
                    this.RaisePropertyChanged("Pseudo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srv.ws_chatSoap")]
    public interface ws_chatSoap {
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément pseudo de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Participer", ReplyAction="*")]
        Discussion.srv.ParticiperResponse Participer(Discussion.srv.ParticiperRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Participer", ReplyAction="*")]
        System.Threading.Tasks.Task<Discussion.srv.ParticiperResponse> ParticiperAsync(Discussion.srv.ParticiperRequest request);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément pseudo de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Quiter", ReplyAction="*")]
        Discussion.srv.QuiterResponse Quiter(Discussion.srv.QuiterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Quiter", ReplyAction="*")]
        System.Threading.Tasks.Task<Discussion.srv.QuiterResponse> QuiterAsync(Discussion.srv.QuiterRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ParticiperRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Participer", Namespace="http://tempuri.org/", Order=0)]
        public Discussion.srv.ParticiperRequestBody Body;
        
        public ParticiperRequest() {
        }
        
        public ParticiperRequest(Discussion.srv.ParticiperRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ParticiperRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string pseudo;
        
        public ParticiperRequestBody() {
        }
        
        public ParticiperRequestBody(string pseudo) {
            this.pseudo = pseudo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ParticiperResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ParticiperResponse", Namespace="http://tempuri.org/", Order=0)]
        public Discussion.srv.ParticiperResponseBody Body;
        
        public ParticiperResponse() {
        }
        
        public ParticiperResponse(Discussion.srv.ParticiperResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ParticiperResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Discussion.srv.Participant[] ParticiperResult;
        
        public ParticiperResponseBody() {
        }
        
        public ParticiperResponseBody(Discussion.srv.Participant[] ParticiperResult) {
            this.ParticiperResult = ParticiperResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QuiterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Quiter", Namespace="http://tempuri.org/", Order=0)]
        public Discussion.srv.QuiterRequestBody Body;
        
        public QuiterRequest() {
        }
        
        public QuiterRequest(Discussion.srv.QuiterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class QuiterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string pseudo;
        
        public QuiterRequestBody() {
        }
        
        public QuiterRequestBody(string pseudo) {
            this.pseudo = pseudo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class QuiterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="QuiterResponse", Namespace="http://tempuri.org/", Order=0)]
        public Discussion.srv.QuiterResponseBody Body;
        
        public QuiterResponse() {
        }
        
        public QuiterResponse(Discussion.srv.QuiterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class QuiterResponseBody {
        
        public QuiterResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ws_chatSoapChannel : Discussion.srv.ws_chatSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ws_chatSoapClient : System.ServiceModel.ClientBase<Discussion.srv.ws_chatSoap>, Discussion.srv.ws_chatSoap {
        
        public ws_chatSoapClient() {
        }
        
        public ws_chatSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ws_chatSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ws_chatSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ws_chatSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Discussion.srv.ParticiperResponse Discussion.srv.ws_chatSoap.Participer(Discussion.srv.ParticiperRequest request) {
            return base.Channel.Participer(request);
        }
        
        public Discussion.srv.Participant[] Participer(string pseudo) {
            Discussion.srv.ParticiperRequest inValue = new Discussion.srv.ParticiperRequest();
            inValue.Body = new Discussion.srv.ParticiperRequestBody();
            inValue.Body.pseudo = pseudo;
            Discussion.srv.ParticiperResponse retVal = ((Discussion.srv.ws_chatSoap)(this)).Participer(inValue);
            return retVal.Body.ParticiperResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Discussion.srv.ParticiperResponse> Discussion.srv.ws_chatSoap.ParticiperAsync(Discussion.srv.ParticiperRequest request) {
            return base.Channel.ParticiperAsync(request);
        }
        
        public System.Threading.Tasks.Task<Discussion.srv.ParticiperResponse> ParticiperAsync(string pseudo) {
            Discussion.srv.ParticiperRequest inValue = new Discussion.srv.ParticiperRequest();
            inValue.Body = new Discussion.srv.ParticiperRequestBody();
            inValue.Body.pseudo = pseudo;
            return ((Discussion.srv.ws_chatSoap)(this)).ParticiperAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Discussion.srv.QuiterResponse Discussion.srv.ws_chatSoap.Quiter(Discussion.srv.QuiterRequest request) {
            return base.Channel.Quiter(request);
        }
        
        public void Quiter(string pseudo) {
            Discussion.srv.QuiterRequest inValue = new Discussion.srv.QuiterRequest();
            inValue.Body = new Discussion.srv.QuiterRequestBody();
            inValue.Body.pseudo = pseudo;
            Discussion.srv.QuiterResponse retVal = ((Discussion.srv.ws_chatSoap)(this)).Quiter(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Discussion.srv.QuiterResponse> Discussion.srv.ws_chatSoap.QuiterAsync(Discussion.srv.QuiterRequest request) {
            return base.Channel.QuiterAsync(request);
        }
        
        public System.Threading.Tasks.Task<Discussion.srv.QuiterResponse> QuiterAsync(string pseudo) {
            Discussion.srv.QuiterRequest inValue = new Discussion.srv.QuiterRequest();
            inValue.Body = new Discussion.srv.QuiterRequestBody();
            inValue.Body.pseudo = pseudo;
            return ((Discussion.srv.ws_chatSoap)(this)).QuiterAsync(inValue);
        }
    }
}
