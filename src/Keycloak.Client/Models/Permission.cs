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
public partial class Permission 
{
    /// <summary>
    /// Gets or Sets Rsid
    /// </summary>
    [JsonPropertyName("rsid")]
    public string Rsid { get; set; }
    
    /// <summary>
    /// Gets or Sets Rsname
    /// </summary>
    [JsonPropertyName("rsname")]
    public string Rsname { get; set; }
    
    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [JsonPropertyName("scopes")]
    public List<string> Scopes { get; set; }
    
    /// <summary>
    /// Gets or Sets Claims
    /// </summary>
    [JsonPropertyName("claims")]
    public Dictionary<string, ArrayList> Claims { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class Permission {\n");
      sb.Append("  Rsid: ").Append(Rsid).Append("\n");
      sb.Append("  Rsname: ").Append(Rsname).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("  Claims: ").Append(Claims).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
