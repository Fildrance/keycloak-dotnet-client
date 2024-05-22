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
public partial class Access 
{
    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    [JsonPropertyName("roles")]
    public List<string> Roles { get; set; }
    
    /// <summary>
    /// Gets or Sets VerifyCaller
    /// </summary>
    [JsonPropertyName("verify_caller")]
    public bool? VerifyCaller { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class Access {\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  VerifyCaller: ").Append(VerifyCaller).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
