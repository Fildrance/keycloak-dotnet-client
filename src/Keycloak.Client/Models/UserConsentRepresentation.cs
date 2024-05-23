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
    public partial class UserConsentRepresentation 
    {
        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }
        
        /// <summary>
        /// Gets or Sets GrantedClientScopes
        /// </summary>
        [JsonPropertyName("grantedClientScopes")]
        public List<string> GrantedClientScopes { get; set; }
        
        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [JsonPropertyName("createdDate")]
        public long? CreatedDate { get; set; }
        
        /// <summary>
        /// Gets or Sets LastUpdatedDate
        /// </summary>
        [JsonPropertyName("lastUpdatedDate")]
        public long? LastUpdatedDate { get; set; }
        
        /// <summary>
        /// Gets or Sets GrantedRealmRoles
        /// </summary>
        [JsonPropertyName("grantedRealmRoles")]
        public List<string> GrantedRealmRoles { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class UserConsentRepresentation {\n");
          sb.Append("  ClientId: ").Append(ClientId).Append("\n");
          sb.Append("  GrantedClientScopes: ").Append(GrantedClientScopes).Append("\n");
          sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
          sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
          sb.Append("  GrantedRealmRoles: ").Append(GrantedRealmRoles).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}