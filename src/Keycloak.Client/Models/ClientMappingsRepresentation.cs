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
    public partial class ClientMappingsRepresentation 
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// Gets or Sets _Client
        /// </summary>
        [JsonPropertyName("client")]
        public string _Client { get; set; }
        
        /// <summary>
        /// Gets or Sets Mappings
        /// </summary>
        [JsonPropertyName("mappings")]
        public List<RoleRepresentation> Mappings { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ClientMappingsRepresentation {\n");
          sb.Append("  Id: ").Append(Id).Append("\n");
          sb.Append("  _Client: ").Append(_Client).Append("\n");
          sb.Append("  Mappings: ").Append(Mappings).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}