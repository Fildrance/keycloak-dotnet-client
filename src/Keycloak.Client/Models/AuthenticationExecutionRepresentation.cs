using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace Keycloak.Client.Models
{
    /// <summary>
    /// 
    /// </summary>
    [GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
    public partial class AuthenticationExecutionRepresentation 
    {
        /// <summary>
        /// Gets or Sets AuthenticatorConfig
        /// </summary>
        [JsonPropertyName("authenticatorConfig")]
        public string AuthenticatorConfig { get; set; }
        
        /// <summary>
        /// Gets or Sets Authenticator
        /// </summary>
        [JsonPropertyName("authenticator")]
        public string Authenticator { get; set; }
        
        /// <summary>
        /// Gets or Sets AuthenticatorFlow
        /// </summary>
        [JsonPropertyName("authenticatorFlow")]
        public bool? AuthenticatorFlow { get; set; }
        
        /// <summary>
        /// Gets or Sets Requirement
        /// </summary>
        [JsonPropertyName("requirement")]
        public string Requirement { get; set; }
        
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }
        
        /// <summary>
        /// Gets or Sets AutheticatorFlow
        /// </summary>
        [JsonPropertyName("autheticatorFlow")]
        public bool? AutheticatorFlow { get; set; }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Gets or Sets FlowId
        /// </summary>
        [JsonPropertyName("flowId")]
        public string FlowId { get; set; }
        
        /// <summary>
        /// Gets or Sets ParentFlow
        /// </summary>
        [JsonPropertyName("parentFlow")]
        public string ParentFlow { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AuthenticationExecutionRepresentation {\n");
          sb.Append("  AuthenticatorConfig: ").Append(AuthenticatorConfig).Append("\n");
          sb.Append("  Authenticator: ").Append(Authenticator).Append("\n");
          sb.Append("  AuthenticatorFlow: ").Append(AuthenticatorFlow).Append("\n");
          sb.Append("  Requirement: ").Append(Requirement).Append("\n");
          sb.Append("  Priority: ").Append(Priority).Append("\n");
          sb.Append("  AutheticatorFlow: ").Append(AutheticatorFlow).Append("\n");
          sb.Append("  Id: ").Append(Id).Append("\n");
          sb.Append("  FlowId: ").Append(FlowId).Append("\n");
          sb.Append("  ParentFlow: ").Append(ParentFlow).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}