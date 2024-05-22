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
public partial class UPAttributeRequired 
{
    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    [JsonPropertyName("roles")]
    public List<string> Roles { get; set; }
    
    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [JsonPropertyName("scopes")]
    public List<string> Scopes { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class UPAttributeRequired {\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
