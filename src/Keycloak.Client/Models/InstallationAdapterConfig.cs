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
public partial class InstallationAdapterConfig 
{
    /// <summary>
    /// Gets or Sets Realm
    /// </summary>
    [JsonPropertyName("realm")]
    public string Realm { get; set; }
    
    /// <summary>
    /// Gets or Sets RealmPublicKey
    /// </summary>
    [JsonPropertyName("realm-public-key")]
    public string RealmPublicKey { get; set; }
    
    /// <summary>
    /// Gets or Sets AuthServerUrl
    /// </summary>
    [JsonPropertyName("auth-server-url")]
    public string AuthServerUrl { get; set; }
    
    /// <summary>
    /// Gets or Sets SslRequired
    /// </summary>
    [JsonPropertyName("ssl-required")]
    public string SslRequired { get; set; }
    
    /// <summary>
    /// Gets or Sets BearerOnly
    /// </summary>
    [JsonPropertyName("bearer-only")]
    public bool? BearerOnly { get; set; }
    
    /// <summary>
    /// Gets or Sets Resource
    /// </summary>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }
    
    /// <summary>
    /// Gets or Sets PublicClient
    /// </summary>
    [JsonPropertyName("public-client")]
    public bool? PublicClient { get; set; }
    
    /// <summary>
    /// Gets or Sets VerifyTokenAudience
    /// </summary>
    [JsonPropertyName("verify-token-audience")]
    public bool? VerifyTokenAudience { get; set; }
    
    /// <summary>
    /// Gets or Sets Credentials
    /// </summary>
    [JsonPropertyName("credentials")]
    public Dictionary<string, Object> Credentials { get; set; }
    
    /// <summary>
    /// Gets or Sets UseResourceRoleMappings
    /// </summary>
    [JsonPropertyName("use-resource-role-mappings")]
    public bool? UseResourceRoleMappings { get; set; }
    
    /// <summary>
    /// Gets or Sets ConfidentialPort
    /// </summary>
    [JsonPropertyName("confidential-port")]
    public int? ConfidentialPort { get; set; }
    
    /// <summary>
    /// Gets or Sets PolicyEnforcer
    /// </summary>
    [JsonPropertyName("policy-enforcer")]
    public PolicyEnforcerConfig PolicyEnforcer { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class InstallationAdapterConfig {\n");
      sb.Append("  Realm: ").Append(Realm).Append("\n");
      sb.Append("  RealmPublicKey: ").Append(RealmPublicKey).Append("\n");
      sb.Append("  AuthServerUrl: ").Append(AuthServerUrl).Append("\n");
      sb.Append("  SslRequired: ").Append(SslRequired).Append("\n");
      sb.Append("  BearerOnly: ").Append(BearerOnly).Append("\n");
      sb.Append("  Resource: ").Append(Resource).Append("\n");
      sb.Append("  PublicClient: ").Append(PublicClient).Append("\n");
      sb.Append("  VerifyTokenAudience: ").Append(VerifyTokenAudience).Append("\n");
      sb.Append("  Credentials: ").Append(Credentials).Append("\n");
      sb.Append("  UseResourceRoleMappings: ").Append(UseResourceRoleMappings).Append("\n");
      sb.Append("  ConfidentialPort: ").Append(ConfidentialPort).Append("\n");
      sb.Append("  PolicyEnforcer: ").Append(PolicyEnforcer).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
