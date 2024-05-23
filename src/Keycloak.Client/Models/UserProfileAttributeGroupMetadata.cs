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
    public partial class UserProfileAttributeGroupMetadata 
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or Sets DisplayHeader
        /// </summary>
        [JsonPropertyName("displayHeader")]
        public string DisplayHeader { get; set; }
        
        /// <summary>
        /// Gets or Sets DisplayDescription
        /// </summary>
        [JsonPropertyName("displayDescription")]
        public string DisplayDescription { get; set; }
        
        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [JsonPropertyName("annotations")]
        public Dictionary<string, Object> Annotations { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class UserProfileAttributeGroupMetadata {\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  DisplayHeader: ").Append(DisplayHeader).Append("\n");
          sb.Append("  DisplayDescription: ").Append(DisplayDescription).Append("\n");
          sb.Append("  Annotations: ").Append(Annotations).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}