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
public partial class PublishedRealmRepresentation 
{
    /// <summary>
    /// Gets or Sets Realm
    /// </summary>
    [JsonPropertyName("realm")]
    public string Realm { get; set; }
    
    /// <summary>
    /// Gets or Sets PublicKey
    /// </summary>
    [JsonPropertyName("public_key")]
    public string PublicKey { get; set; }
    
    /// <summary>
    /// Gets or Sets TokenService
    /// </summary>
    [JsonPropertyName("token-service")]
    public string TokenService { get; set; }
    
    /// <summary>
    /// Gets or Sets AccountService
    /// </summary>
    [JsonPropertyName("account-service")]
    public string AccountService { get; set; }
    
    /// <summary>
    /// Gets or Sets TokensNotBefore
    /// </summary>
    [JsonPropertyName("tokens-not-before")]
    public int? TokensNotBefore { get; set; }
    
    
    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  
    {
      var sb = new StringBuilder();
      sb.Append("class PublishedRealmRepresentation {\n");
      sb.Append("  Realm: ").Append(Realm).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  TokenService: ").Append(TokenService).Append("\n");
      sb.Append("  AccountService: ").Append(AccountService).Append("\n");
      sb.Append("  TokensNotBefore: ").Append(TokensNotBefore).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }
    
}
