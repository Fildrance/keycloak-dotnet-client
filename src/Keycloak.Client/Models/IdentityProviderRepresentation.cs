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
    public partial class IdentityProviderRepresentation 
    {
        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [JsonPropertyName("alias")]
        public string Alias { get; set; }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        
        /// <summary>
        /// Gets or Sets InternalId
        /// </summary>
        [JsonPropertyName("internalId")]
        public string InternalId { get; set; }
        
        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
        /// <summary>
        /// Gets or Sets UpdateProfileFirstLoginMode
        /// </summary>
        [JsonPropertyName("updateProfileFirstLoginMode")]
        public string UpdateProfileFirstLoginMode { get; set; }
        
        /// <summary>
        /// Gets or Sets TrustEmail
        /// </summary>
        [JsonPropertyName("trustEmail")]
        public bool? TrustEmail { get; set; }
        
        /// <summary>
        /// Gets or Sets StoreToken
        /// </summary>
        [JsonPropertyName("storeToken")]
        public bool? StoreToken { get; set; }
        
        /// <summary>
        /// Gets or Sets AddReadTokenRoleOnCreate
        /// </summary>
        [JsonPropertyName("addReadTokenRoleOnCreate")]
        public bool? AddReadTokenRoleOnCreate { get; set; }
        
        /// <summary>
        /// Gets or Sets AuthenticateByDefault
        /// </summary>
        [JsonPropertyName("authenticateByDefault")]
        public bool? AuthenticateByDefault { get; set; }
        
        /// <summary>
        /// Gets or Sets LinkOnly
        /// </summary>
        [JsonPropertyName("linkOnly")]
        public bool? LinkOnly { get; set; }
        
        /// <summary>
        /// Gets or Sets FirstBrokerLoginFlowAlias
        /// </summary>
        [JsonPropertyName("firstBrokerLoginFlowAlias")]
        public string FirstBrokerLoginFlowAlias { get; set; }
        
        /// <summary>
        /// Gets or Sets PostBrokerLoginFlowAlias
        /// </summary>
        [JsonPropertyName("postBrokerLoginFlowAlias")]
        public string PostBrokerLoginFlowAlias { get; set; }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonPropertyName("config")]
        public Dictionary<string, string> Config { get; set; }
        
        /// <summary>
        /// Gets or Sets UpdateProfileFirstLogin
        /// </summary>
        [JsonPropertyName("updateProfileFirstLogin")]
        public bool? UpdateProfileFirstLogin { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class IdentityProviderRepresentation {\n");
          sb.Append("  Alias: ").Append(Alias).Append("\n");
          sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
          sb.Append("  InternalId: ").Append(InternalId).Append("\n");
          sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
          sb.Append("  Enabled: ").Append(Enabled).Append("\n");
          sb.Append("  UpdateProfileFirstLoginMode: ").Append(UpdateProfileFirstLoginMode).Append("\n");
          sb.Append("  TrustEmail: ").Append(TrustEmail).Append("\n");
          sb.Append("  StoreToken: ").Append(StoreToken).Append("\n");
          sb.Append("  AddReadTokenRoleOnCreate: ").Append(AddReadTokenRoleOnCreate).Append("\n");
          sb.Append("  AuthenticateByDefault: ").Append(AuthenticateByDefault).Append("\n");
          sb.Append("  LinkOnly: ").Append(LinkOnly).Append("\n");
          sb.Append("  FirstBrokerLoginFlowAlias: ").Append(FirstBrokerLoginFlowAlias).Append("\n");
          sb.Append("  PostBrokerLoginFlowAlias: ").Append(PostBrokerLoginFlowAlias).Append("\n");
          sb.Append("  Config: ").Append(Config).Append("\n");
          sb.Append("  UpdateProfileFirstLogin: ").Append(UpdateProfileFirstLogin).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}