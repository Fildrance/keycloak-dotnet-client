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
    public partial class AuthenticatorConfigInfoRepresentation 
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or Sets ProviderId
        /// </summary>
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
        
        /// <summary>
        /// Gets or Sets HelpText
        /// </summary>
        [JsonPropertyName("helpText")]
        public string HelpText { get; set; }
        
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [JsonPropertyName("properties")]
        public List<ConfigPropertyRepresentation> Properties { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AuthenticatorConfigInfoRepresentation {\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
          sb.Append("  HelpText: ").Append(HelpText).Append("\n");
          sb.Append("  Properties: ").Append(Properties).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}