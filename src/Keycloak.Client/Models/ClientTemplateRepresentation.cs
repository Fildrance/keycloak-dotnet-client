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
public partial class ClientTemplateRepresentation 
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
    /// Gets or Sets Protocol
    /// </summary>
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
    
    /// <summary>
    /// Gets or Sets FullScopeAllowed
    /// </summary>
    [JsonPropertyName("fullScopeAllowed")]
    public bool? FullScopeAllowed { get; set; }
    
    /// <summary>
    /// Gets or Sets BearerOnly
    /// </summary>
    [JsonPropertyName("bearerOnly")]
    public bool? BearerOnly { get; set; }
    
    /// <summary>
    /// Gets or Sets ConsentRequired
    /// </summary>
    [JsonPropertyName("consentRequired")]
    public bool? ConsentRequired { get; set; }
    
    /// <summary>
    /// Gets or Sets StandardFlowEnabled
    /// </summary>
    [JsonPropertyName("standardFlowEnabled")]
    public bool? StandardFlowEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets ImplicitFlowEnabled
    /// </summary>
    [JsonPropertyName("implicitFlowEnabled")]
    public bool? ImplicitFlowEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets DirectAccessGrantsEnabled
    /// </summary>
    [JsonPropertyName("directAccessGrantsEnabled")]
    public bool? DirectAccessGrantsEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets ServiceAccountsEnabled
    /// </summary>
    [JsonPropertyName("serviceAccountsEnabled")]
    public bool? ServiceAccountsEnabled { get; set; }
    
    /// <summary>
    /// Gets or Sets PublicClient
    /// </summary>
    [JsonPropertyName("publicClient")]
    public bool? PublicClient { get; set; }
    
    /// <summary>
    /// Gets or Sets FrontchannelLogout
    /// </summary>
    [JsonPropertyName("frontchannelLogout")]
    public bool? FrontchannelLogout { get; set; }
    
    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }
    
    /// <summary>
    /// Gets or Sets ProtocolMappers
    /// </summary>
    [JsonPropertyName("protocolMappers")]
    public List<ProtocolMapperRepresentation> ProtocolMappers { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class ClientTemplateRepresentation {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  FullScopeAllowed: ").Append(FullScopeAllowed).Append("\n");
      sb.Append("  BearerOnly: ").Append(BearerOnly).Append("\n");
      sb.Append("  ConsentRequired: ").Append(ConsentRequired).Append("\n");
      sb.Append("  StandardFlowEnabled: ").Append(StandardFlowEnabled).Append("\n");
      sb.Append("  ImplicitFlowEnabled: ").Append(ImplicitFlowEnabled).Append("\n");
      sb.Append("  DirectAccessGrantsEnabled: ").Append(DirectAccessGrantsEnabled).Append("\n");
      sb.Append("  ServiceAccountsEnabled: ").Append(ServiceAccountsEnabled).Append("\n");
      sb.Append("  PublicClient: ").Append(PublicClient).Append("\n");
      sb.Append("  FrontchannelLogout: ").Append(FrontchannelLogout).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
      sb.Append("  ProtocolMappers: ").Append(ProtocolMappers).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
