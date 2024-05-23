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
    public partial class SocialLinkRepresentation 
    {
        /// <summary>
        /// Gets or Sets SocialProvider
        /// </summary>
        [JsonPropertyName("socialProvider")]
        public string SocialProvider { get; set; }
        
        /// <summary>
        /// Gets or Sets SocialUserId
        /// </summary>
        [JsonPropertyName("socialUserId")]
        public string SocialUserId { get; set; }
        
        /// <summary>
        /// Gets or Sets SocialUsername
        /// </summary>
        [JsonPropertyName("socialUsername")]
        public string SocialUsername { get; set; }
        
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class SocialLinkRepresentation {\n");
          sb.Append("  SocialProvider: ").Append(SocialProvider).Append("\n");
          sb.Append("  SocialUserId: ").Append(SocialUserId).Append("\n");
          sb.Append("  SocialUsername: ").Append(SocialUsername).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
        
    }
}