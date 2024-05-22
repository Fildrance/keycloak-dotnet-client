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
public partial class KeyMetadataRepresentation 
{
    /// <summary>
    /// Gets or Sets ProviderId
    /// </summary>
    [JsonPropertyName("providerId")]
    public string ProviderId { get; set; }
    
    /// <summary>
    /// Gets or Sets ProviderPriority
    /// </summary>
    [JsonPropertyName("providerPriority")]
    public long? ProviderPriority { get; set; }
    
    /// <summary>
    /// Gets or Sets Kid
    /// </summary>
    [JsonPropertyName("kid")]
    public string Kid { get; set; }
    
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
    
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }
    
    /// <summary>
    /// Gets or Sets Algorithm
    /// </summary>
    [JsonPropertyName("algorithm")]
    public string Algorithm { get; set; }
    
    /// <summary>
    /// Gets or Sets PublicKey
    /// </summary>
    [JsonPropertyName("publicKey")]
    public string PublicKey { get; set; }
    
    /// <summary>
    /// Gets or Sets Certificate
    /// </summary>
    [JsonPropertyName("certificate")]
    public string Certificate { get; set; }
    
    /// <summary>
    /// Gets or Sets Use
    /// </summary>
    [JsonPropertyName("use")]
    public KeyUse Use { get; set; }
    
    /// <summary>
    /// Gets or Sets ValidTo
    /// </summary>
    [JsonPropertyName("validTo")]
    public long? ValidTo { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class KeyMetadataRepresentation {\n");
      sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
      sb.Append("  ProviderPriority: ").Append(ProviderPriority).Append("\n");
      sb.Append("  Kid: ").Append(Kid).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  Certificate: ").Append(Certificate).Append("\n");
      sb.Append("  Use: ").Append(Use).Append("\n");
      sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
