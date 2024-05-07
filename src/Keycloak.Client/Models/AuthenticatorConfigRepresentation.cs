using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Text;
using System.Text.Json.Serialization;

namespace IO.Swagger.Model;

/// <summary>
/// 
/// </summary>
[GeneratedCode("swagger-codegen", "3.0.56-SNAPSHOT")]
public partial class AuthenticatorConfigRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Alias
    /// </summary>
    [JsonPropertyName("alias")]
    public string Alias { get; set; }
    
    /// <summary>
    /// Gets or Sets Config
    /// </summary>
    [JsonPropertyName("config")]
    public Dictionary<string, string> Config { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class AuthenticatorConfigRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  Config: ").Append(Config).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
