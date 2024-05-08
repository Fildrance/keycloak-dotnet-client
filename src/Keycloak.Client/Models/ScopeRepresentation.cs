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
public partial class ScopeRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets IconUri
    /// </summary>
    [JsonPropertyName("iconUri")]
    public string IconUri { get; set; }
    
    /// <summary>
    /// Gets or Sets Policies
    /// </summary>
    [JsonPropertyName("policies")]
    public List<PolicyRepresentation> Policies { get; set; }
    
    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [JsonPropertyName("resources")]
    public List<ResourceRepresentation> Resources { get; set; }
    
    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ScopeRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  IconUri: ").Append(IconUri).Append("\n");
      sb.Append("  Policies: ").Append(Policies).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
