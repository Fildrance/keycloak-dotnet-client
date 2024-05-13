using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace PetShop.Models;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class KeysMetadataRepresentation 
{
    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [JsonPropertyName("active")]
    public Dictionary<string, string> Active { get; set; }
    
    /// <summary>
    /// Gets or Sets Keys
    /// </summary>
    [JsonPropertyName("keys")]
    public List<KeyMetadataRepresentation> Keys { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class KeysMetadataRepresentation {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Keys: ").Append(Keys).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
