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
    public partial class UserProfileAttributeMetadata 
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        
        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [JsonPropertyName("required")]
        public bool? Required { get; set; }
        
        /// <summary>
        /// Gets or Sets _ReadOnly
        /// </summary>
        [JsonPropertyName("readOnly")]
        public bool? _ReadOnly { get; set; }
        
        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [JsonPropertyName("annotations")]
        public Dictionary<string, Object> Annotations { get; set; }
        
        /// <summary>
        /// Gets or Sets Validators
        /// </summary>
        [JsonPropertyName("validators")]
        public Dictionary<string, Dictionary<string, Object>> Validators { get; set; }
        
        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [JsonPropertyName("group")]
        public string Group { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class UserProfileAttributeMetadata {\n");
          sb.Append("  Name: ").Append(Name).Append("\n");
          sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
          sb.Append("  Required: ").Append(Required).Append("\n");
          sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
          sb.Append("  Annotations: ").Append(Annotations).Append("\n");
          sb.Append("  Validators: ").Append(Validators).Append("\n");
          sb.Append("  Group: ").Append(Group).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}