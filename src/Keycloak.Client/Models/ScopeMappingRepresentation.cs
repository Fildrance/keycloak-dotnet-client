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
public partial class ScopeMappingRepresentation 
{
    /// <summary>
    /// Gets or Sets Self
    /// </summary>
    [JsonPropertyName("self")]
    public string Self { get; set; }
    
    /// <summary>
    /// Gets or Sets _Client
    /// </summary>
    [JsonPropertyName("client")]
    public string _Client { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientTemplate
    /// </summary>
    [JsonPropertyName("clientTemplate")]
    public string ClientTemplate { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientScope
    /// </summary>
    [JsonPropertyName("clientScope")]
    public string ClientScope { get; set; }
    
    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    [JsonPropertyName("roles")]
    public List<string> Roles { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ScopeMappingRepresentation {\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
      sb.Append("  _Client: ").Append(_Client).Append("\n");
      sb.Append("  ClientTemplate: ").Append(ClientTemplate).Append("\n");
      sb.Append("  ClientScope: ").Append(ClientScope).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
