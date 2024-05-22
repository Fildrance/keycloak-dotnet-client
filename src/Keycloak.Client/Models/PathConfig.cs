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
public partial class PathConfig 
{
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    /// <summary>
    /// Gets or Sets Path
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }
    
    /// <summary>
    /// Gets or Sets Methods
    /// </summary>
    [JsonPropertyName("methods")]
    public List<MethodConfig> Methods { get; set; }
    
    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [JsonPropertyName("scopes")]
    public List<string> Scopes { get; set; }
    
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets EnforcementMode
    /// </summary>
    [JsonPropertyName("enforcement-mode")]
    public EnforcementMode EnforcementMode { get; set; }
    
    /// <summary>
    /// Gets or Sets ClaimInformationPoint
    /// </summary>
    [JsonPropertyName("claim-information-point")]
    public Dictionary<string, Dictionary<string, Object>> ClaimInformationPoint { get; set; }
    
    /// <summary>
    /// Gets or Sets Invalidated
    /// </summary>
    [JsonPropertyName("invalidated")]
    public bool? Invalidated { get; set; }
    
    /// <summary>
    /// Gets or Sets StaticPath
    /// </summary>
    [JsonPropertyName("staticPath")]
    public bool? StaticPath { get; set; }
    
    /// <summary>
    /// Gets or Sets _Static
    /// </summary>
    [JsonPropertyName("static")]
    public bool? _Static { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class PathConfig {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Methods: ").Append(Methods).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  EnforcementMode: ").Append(EnforcementMode).Append("\n");
      sb.Append("  ClaimInformationPoint: ").Append(ClaimInformationPoint).Append("\n");
      sb.Append("  Invalidated: ").Append(Invalidated).Append("\n");
      sb.Append("  StaticPath: ").Append(StaticPath).Append("\n");
      sb.Append("  _Static: ").Append(_Static).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
