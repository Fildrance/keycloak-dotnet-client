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
    public partial class ComponentExportRepresentation 
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
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
        /// Gets or Sets SubType
        /// </summary>
        [JsonPropertyName("subType")]
        public string SubType { get; set; }
        
        /// <summary>
        /// Gets or Sets SubComponents
        /// </summary>
        [JsonPropertyName("subComponents")]
        public Dictionary<string, ArrayList> SubComponents { get; set; }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonPropertyName("config")]
        public Dictionary<string, ArrayList> Config { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ComponentExportRepresentation {\n");
          sb.Append("  Id: ").Append(Id).Append("\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
          sb.Append("  SubType: ").Append(SubType).Append("\n");
          sb.Append("  SubComponents: ").Append(SubComponents).Append("\n");
          sb.Append("  Config: ").Append(Config).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}