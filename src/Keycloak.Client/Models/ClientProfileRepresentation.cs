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
    public partial class ClientProfileRepresentation 
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        /// <summary>
        /// Gets or Sets Executors
        /// </summary>
        [JsonPropertyName("executors")]
        public List<ClientPolicyExecutorRepresentation> Executors { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ClientProfileRepresentation {\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  Description: ").Append(Description).Append("\n");
          sb.Append("  Executors: ").Append(Executors).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}