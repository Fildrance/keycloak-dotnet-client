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
    public partial class RequiredActionProviderRepresentation 
    {
        /// <summary>
        /// Gets or Sets Alias
        /// </summary>
        [JsonPropertyName("alias")]
        public string Alias { get; set; }
        
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
        /// Gets or Sets Enabled
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
        /// <summary>
        /// Gets or Sets DefaultAction
        /// </summary>
        [JsonPropertyName("defaultAction")]
        public bool? DefaultAction { get; set; }
        
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [JsonPropertyName("priority")]
        public int? Priority { get; set; }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonPropertyName("config")]
        public Dictionary<string, string> Config { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RequiredActionProviderRepresentation {\n");
          sb.Append("  Alias: ").Append(Alias).Append("\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
          sb.Append("  Enabled: ").Append(Enabled).Append("\n");
          sb.Append("  DefaultAction: ").Append(DefaultAction).Append("\n");
          sb.Append("  Priority: ").Append(Priority).Append("\n");
          sb.Append("  Config: ").Append(Config).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}