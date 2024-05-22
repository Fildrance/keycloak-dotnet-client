using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace Keycloak.Client.Models;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class UserProfileMetadata 
{
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public List<UserProfileAttributeMetadata> Attributes { get; set; }
    
    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [JsonPropertyName("groups")]
    public List<UserProfileAttributeGroupMetadata> Groups { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class UserProfileMetadata {\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
