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
public partial class RoleRepresentation 
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
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    /// <summary>
    /// Gets or Sets ScopeParamRequired
    /// </summary>
    [JsonPropertyName("scopeParamRequired")]
    public bool? ScopeParamRequired { get; set; }
    
    /// <summary>
    /// Gets or Sets Composite
    /// </summary>
    [JsonPropertyName("composite")]
    public bool? Composite { get; set; }
    
    /// <summary>
    /// Gets or Sets Composites
    /// </summary>
    [JsonPropertyName("composites")]
    public Composites Composites { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientRole
    /// </summary>
    [JsonPropertyName("clientRole")]
    public bool? ClientRole { get; set; }
    
    /// <summary>
    /// Gets or Sets ContainerId
    /// </summary>
    [JsonPropertyName("containerId")]
    public string ContainerId { get; set; }
    
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public Dictionary<string, ArrayList> Attributes { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class RoleRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ScopeParamRequired: ").Append(ScopeParamRequired).Append("\n");
      sb.Append("  Composite: ").Append(Composite).Append("\n");
      sb.Append("  Composites: ").Append(Composites).Append("\n");
      sb.Append("  ClientRole: ").Append(ClientRole).Append("\n");
      sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
