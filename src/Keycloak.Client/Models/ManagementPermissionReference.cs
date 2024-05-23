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
    public partial class ManagementPermissionReference 
    {
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [JsonPropertyName("resource")]
        public string Resource { get; set; }
        
        /// <summary>
        /// Gets or Sets ScopePermissions
        /// </summary>
        [JsonPropertyName("scopePermissions")]
        public Dictionary<string, string> ScopePermissions { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ManagementPermissionReference {\n");
          sb.Append("  Enabled: ").Append(Enabled).Append("\n");
          sb.Append("  Resource: ").Append(Resource).Append("\n");
          sb.Append("  ScopePermissions: ").Append(ScopePermissions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}