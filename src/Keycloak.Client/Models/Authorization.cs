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
    public partial class Authorization 
    {
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [JsonPropertyName("permissions")]
        public List<Permission> Permissions { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Authorization {\n");
          sb.Append("  Permissions: ").Append(Permissions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}