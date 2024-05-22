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
public partial class Confirmation 
{
    /// <summary>
    /// Gets or Sets X5tS256
    /// </summary>
    [JsonPropertyName("x5t#S256")]
    public string X5tS256 { get; set; }
    
    /// <summary>
    /// Gets or Sets Jkt
    /// </summary>
    [JsonPropertyName("jkt")]
    public string Jkt { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class Confirmation {\n");
      sb.Append("  X5tS256: ").Append(X5tS256).Append("\n");
      sb.Append("  Jkt: ").Append(Jkt).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
