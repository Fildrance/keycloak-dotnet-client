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
public partial class AuthenticationExecutionInfoRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets Requirement
    /// </summary>
    [JsonPropertyName("requirement")]
    public string Requirement { get; set; }
    
    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }
    
    /// <summary>
    /// Gets or Sets Alias
    /// </summary>
    [JsonPropertyName("alias")]
    public string Alias { get; set; }
    
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    /// <summary>
    /// Gets or Sets RequirementChoices
    /// </summary>
    [JsonPropertyName("requirementChoices")]
    public List<string> RequirementChoices { get; set; }
    
    /// <summary>
    /// Gets or Sets Configurable
    /// </summary>
    [JsonPropertyName("configurable")]
    public bool? Configurable { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthenticationFlow
    /// </summary>
    [JsonPropertyName("authenticationFlow")]
    public bool? AuthenticationFlow { get; set; }
    
    /// <summary>
    /// Gets or Sets ProviderId
    /// </summary>
    [JsonPropertyName("providerId")]
    public string ProviderId { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthenticationConfig
    /// </summary>
    [JsonPropertyName("authenticationConfig")]
    public string AuthenticationConfig { get; set; }
    
    /// <summary>
    /// Gets or Sets FlowId
    /// </summary>
    [JsonPropertyName("flowId")]
    public string FlowId { get; set; }
    
    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    [JsonPropertyName("level")]
    public int? Level { get; set; }
    
    /// <summary>
    /// Gets or Sets Index
    /// </summary>
    [JsonPropertyName("index")]
    public int? Index { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationExecutionInfoRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Requirement: ").Append(Requirement).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  RequirementChoices: ").Append(RequirementChoices).Append("\n");
      sb.Append("  Configurable: ").Append(Configurable).Append("\n");
      sb.Append("  AuthenticationFlow: ").Append(AuthenticationFlow).Append("\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  AuthenticationConfig: ").Append(AuthenticationConfig).Append("\n");
      sb.Append("  FlowId: ").Append(FlowId).Append("\n");
      sb.Append("  Level: ").Append(Level).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
