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
public partial class ResourceServerRepresentation 
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }
    
    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [JsonPropertyName("clientId")]
    public string ClientId { get; set; }
    
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    /// <summary>
    /// Gets or Sets AllowRemoteResourceManagement
    /// </summary>
    [JsonPropertyName("allowRemoteResourceManagement")]
    public bool? AllowRemoteResourceManagement { get; set; }
    
    /// <summary>
    /// Gets or Sets PolicyEnforcementMode
    /// </summary>
    [JsonPropertyName("policyEnforcementMode")]
    public PolicyEnforcementMode PolicyEnforcementMode { get; set; }
    
    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    [JsonPropertyName("resources")]
    public List<ResourceRepresentation> Resources { get; set; }
    
    /// <summary>
    /// Gets or Sets Policies
    /// </summary>
    [JsonPropertyName("policies")]
    public List<PolicyRepresentation> Policies { get; set; }
    
    /// <summary>
    /// Gets or Sets Scopes
    /// </summary>
    [JsonPropertyName("scopes")]
    public List<ScopeRepresentation> Scopes { get; set; }
    
    /// <summary>
    /// Gets or Sets DecisionStrategy
    /// </summary>
    [JsonPropertyName("decisionStrategy")]
    public DecisionStrategy DecisionStrategy { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ResourceServerRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AllowRemoteResourceManagement: ").Append(AllowRemoteResourceManagement).Append("\n");
      sb.Append("  PolicyEnforcementMode: ").Append(PolicyEnforcementMode).Append("\n");
      sb.Append("  Resources: ").Append(Resources).Append("\n");
      sb.Append("  Policies: ").Append(Policies).Append("\n");
      sb.Append("  Scopes: ").Append(Scopes).Append("\n");
      sb.Append("  DecisionStrategy: ").Append(DecisionStrategy).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
