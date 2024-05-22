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
public partial class ClientPolicyRepresentation 
{
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
    
    /// <summary>
    /// Gets or Sets Conditions
    /// </summary>
    [JsonPropertyName("conditions")]
    public List<ClientPolicyConditionRepresentation> Conditions { get; set; }
    
    /// <summary>
    /// Gets or Sets Profiles
    /// </summary>
    [JsonPropertyName("profiles")]
    public List<string> Profiles { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ClientPolicyRepresentation {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  Profiles: ").Append(Profiles).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
