﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceClient.SampleServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://samplewcf.dev.com/", ConfigurationName="SampleServiceRef.IWcfService")]
    public interface IWcfService {
        
        // CODEGEN: Generating message contract since element name GetRamdomGuidResult from namespace https://samplewcf.dev.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="https://samplewcf.dev.com/IWcfService/GetRamdomGuid", ReplyAction="https://samplewcf.dev.com/IWcfService/GetRamdomGuidResponse")]
        WcfServiceClient.SampleServiceRef.GetRamdomGuidResponse GetRamdomGuid(WcfServiceClient.SampleServiceRef.GetRamdomGuidRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://samplewcf.dev.com/IWcfService/GetRamdomGuid", ReplyAction="https://samplewcf.dev.com/IWcfService/GetRamdomGuidResponse")]
        System.Threading.Tasks.Task<WcfServiceClient.SampleServiceRef.GetRamdomGuidResponse> GetRamdomGuidAsync(WcfServiceClient.SampleServiceRef.GetRamdomGuidRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRamdomGuidRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRamdomGuid", Namespace="https://samplewcf.dev.com/", Order=0)]
        public WcfServiceClient.SampleServiceRef.GetRamdomGuidRequestBody Body;
        
        public GetRamdomGuidRequest() {
        }
        
        public GetRamdomGuidRequest(WcfServiceClient.SampleServiceRef.GetRamdomGuidRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetRamdomGuidRequestBody {
        
        public GetRamdomGuidRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetRamdomGuidResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRamdomGuidResponse", Namespace="https://samplewcf.dev.com/", Order=0)]
        public WcfServiceClient.SampleServiceRef.GetRamdomGuidResponseBody Body;
        
        public GetRamdomGuidResponse() {
        }
        
        public GetRamdomGuidResponse(WcfServiceClient.SampleServiceRef.GetRamdomGuidResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://samplewcf.dev.com/")]
    public partial class GetRamdomGuidResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetRamdomGuidResult;
        
        public GetRamdomGuidResponseBody() {
        }
        
        public GetRamdomGuidResponseBody(string GetRamdomGuidResult) {
            this.GetRamdomGuidResult = GetRamdomGuidResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfServiceChannel : WcfServiceClient.SampleServiceRef.IWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfServiceClient : System.ServiceModel.ClientBase<WcfServiceClient.SampleServiceRef.IWcfService>, WcfServiceClient.SampleServiceRef.IWcfService {
        
        public WcfServiceClient() {
        }
        
        public WcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WcfServiceClient.SampleServiceRef.GetRamdomGuidResponse WcfServiceClient.SampleServiceRef.IWcfService.GetRamdomGuid(WcfServiceClient.SampleServiceRef.GetRamdomGuidRequest request) {
            return base.Channel.GetRamdomGuid(request);
        }
        
        public string GetRamdomGuid() {
            WcfServiceClient.SampleServiceRef.GetRamdomGuidRequest inValue = new WcfServiceClient.SampleServiceRef.GetRamdomGuidRequest();
            inValue.Body = new WcfServiceClient.SampleServiceRef.GetRamdomGuidRequestBody();
            WcfServiceClient.SampleServiceRef.GetRamdomGuidResponse retVal = ((WcfServiceClient.SampleServiceRef.IWcfService)(this)).GetRamdomGuid(inValue);
            return retVal.Body.GetRamdomGuidResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WcfServiceClient.SampleServiceRef.GetRamdomGuidResponse> WcfServiceClient.SampleServiceRef.IWcfService.GetRamdomGuidAsync(WcfServiceClient.SampleServiceRef.GetRamdomGuidRequest request) {
            return base.Channel.GetRamdomGuidAsync(request);
        }
        
        public System.Threading.Tasks.Task<WcfServiceClient.SampleServiceRef.GetRamdomGuidResponse> GetRamdomGuidAsync() {
            WcfServiceClient.SampleServiceRef.GetRamdomGuidRequest inValue = new WcfServiceClient.SampleServiceRef.GetRamdomGuidRequest();
            inValue.Body = new WcfServiceClient.SampleServiceRef.GetRamdomGuidRequestBody();
            return ((WcfServiceClient.SampleServiceRef.IWcfService)(this)).GetRamdomGuidAsync(inValue);
        }
    }
}